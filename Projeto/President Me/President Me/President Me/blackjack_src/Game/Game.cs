/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.Text;

using Common;
using System.Threading;

namespace Game
{
	public enum GameStatus
	{
		Stopped,
		Paused,
		Playing
	}

	#region "Event Delegates"

	public delegate void GameStatusChangeDelegate(GameStatus status);
	public delegate void EndOfRoundDelegate(int currentRound, List<PlayerStatus> players);

	public delegate void PlayerListChangeDelegate(IPlayer player, bool isDealer);
	public delegate void PlayerListClearedDelegate();

	public delegate void DealerChangeDelegate(IPlayer oldDealer, IPlayer newDealer);

	#endregion

	public class Game
	{
		#region "Game Control"

		public void NewGame()
		{
			lock (this)
			{
				if (_status != GameStatus.Stopped)
					throw new Exception("The game is already running");

				if (_dealer == null)
					throw new Exception("No dealer!");

				if (_players.Count < 2)
					throw new Exception("Threre mus be at least two players to play the game");

				InitDeck();

				_currentRound = 1;

				foreach (PlayerStatus player in _players)
					player.ClearStatistics();

				Status = GameStatus.Playing;
				Thread t = new Thread(new ThreadStart(GameThread));
				t.Start();
			}
		}

		public void StopGame()
		{
			lock (this)
			{
				if (_status == GameStatus.Stopped)
					throw new Exception("There is no game to be stopped");

				Status = GameStatus.Stopped;
			}
		}

		public void PauseGame()
		{
			lock (this)
			{
				if (_status != GameStatus.Playing)
					throw new Exception("There is no game to be paused");

				Status = GameStatus.Paused;
			}
		}

		public void ContinueGame()
		{
			lock (this)
			{
				if (_status != GameStatus.Paused)
					throw new Exception("Trying to resume game which is not paused");

				Status = GameStatus.Playing;
				Thread t = new Thread(new ThreadStart(GameThread));
				t.Start();
			}
		}

		private void GameThread()
		{
			ResetAnimationSynchronizator();

			for (; _currentRound <= _numberOfRounds && Status == GameStatus.Playing; _currentRound++)
			{
				Round();

				RaiseOnRoundEnd();

				WaitForAnimation();
			}

			RaiseOnGameEnd();

			lock (this)
			{
				if (_status == GameStatus.Playing)
					Status = GameStatus.Stopped;
			}
		}

		#endregion

		#region "Game Status"

		private GameStatus _status = GameStatus.Stopped;

		public GameStatus Status
		{
			get
			{
				lock (this)
				{
					return _status;
				}
			}

			protected set
			{
				if (_status == value)
					return;

				_status = value;
				RaiseOnStatusChanged();
			}
		}

		#endregion

		#region "Round Counting"

		private int _numberOfRounds = 100000;

		public int NumberOfRounds
		{
			get { return _numberOfRounds; }
			set
			{
				if (Status != GameStatus.Stopped)
					throw new Exception("To change number of rounds to play game must be stopped");

				_numberOfRounds = value > 0 ? value : 1;
			}
		}

		private int _currentRound = 1;

		public int CurrentRound
		{
			get { return _currentRound; }
		}

		#endregion

		#region "Synchronization With GUI"

		private ManualResetEvent _animationSynchronization = new ManualResetEvent(false);

		private void ResetAnimationSynchronizator()
		{
			_animationSynchronization.Reset();
		}

		private void WaitForAnimation()
		{
			_animationSynchronization.WaitOne();
			_animationSynchronization.Reset();
		}

		public void AnimationFinished()
		{
			_animationSynchronization.Set();
		}

		#endregion

		#region "Inner Game Logics"

		private void Round()
		{
			BeginRound();

			bool hasActivePlayer = false;
			do
			{
				hasActivePlayer = false;

				foreach (PlayerStatus player in _players)
					hasActivePlayer |= PlayerTurn(player);

			} while (hasActivePlayer);

			EndRound();
		}

		private void BeginRound()
		{
			_deck.ReturnCards(_dealedCards);
			_dealedCards.Clear();

			_dealer.NewRound(CurrentRound == 1, true, 0, _numberOfDecks);

			int dealersFirstCard = GiveCardToPlayer(_dealer);
			GiveCardToPlayer(_dealer);

			foreach (PlayerStatus player in _players)
			{
				if (player == _dealer)
					continue;

				player.NewRound(CurrentRound == 1, false, dealersFirstCard, _numberOfDecks);

				GiveCardToPlayer(player);
				GiveCardToPlayer(player);
			}
		}

		private bool PlayerTurn(PlayerStatus player)
		{
			bool played = false;

			if (player.InGameStatus == PlayerInGameStatus.Playing)
			{
				if (player.Player.Turn(_deck.CardsLeft) == PlayerOptions.Hit)
				{
					if (_deck.CardsLeft == 0)
						player.InGameStatus = PlayerInGameStatus.Stand;
					else
					{
						GiveCardToPlayer(player);

						played = true;
					}
				}
				else
					player.InGameStatus = PlayerInGameStatus.Stand;
			}

			return played;
		}

		private int GiveCardToPlayer(PlayerStatus player)
		{
			int card = _deck.TakeCard();

			player.GiveCard(card);
			_dealedCards.Add(card);

			return card;
		}

		private void EndRound()
		{
			List<PlayerStatus> _winners = new List<PlayerStatus>();
			List<PlayerStatus> _blackjacks = new List<PlayerStatus>();

			foreach (PlayerStatus player in _players)
			{
				if (player.PlayerHand.IsBlackJack)
					_blackjacks.Add(player);
				else if (player.PlayerHand.IsBusted)
				{
					if (player != _dealer)
						player.IncLooses(true, _dealedCards);
				}
				else
					_winners.Add(player);
			}

			if (_blackjacks.Count > 0)
			{
				foreach (PlayerStatus player in _winners)
					player.IncLooses(false, _dealedCards);

				if (_blackjacks.Count == 1)
					_blackjacks[0].IncWins(true, _dealedCards);
				else
				{
					bool dealersBlackJack = _dealer.PlayerHand.IsBlackJack;
					if (dealersBlackJack)
						_dealer.IncWins(true, _dealedCards);

					foreach (PlayerStatus player in _blackjacks)
					{
						if (player == _dealer)
							continue;

						if (!dealersBlackJack)
							player.IncDraws(_dealedCards);
						else
							player.IncLooses(false, _dealedCards);
					}
				}

				if (_dealer.PlayerHand.IsBusted)
					_dealer.IncLooses(true, _dealedCards);
			}
			else
			{
				if (_winners.Count == 0)
				{
					if (_dealer.PlayerHand.IsBusted)
						_dealer.IncWins(false, _dealedCards);

					return;
				}

				if (_dealer.PlayerHand.IsBusted)
					_dealer.IncLooses(true, _dealedCards);

				if (_winners.Count == 1)
				{
					_winners[0].IncWins(false, _dealedCards);
					return;
				}

				_winners.Sort(
					delegate(PlayerStatus x, PlayerStatus y)
					{
						return x.PlayerHand.ClosestValue - y.PlayerHand.ClosestValue;
					}
					);

				if (_winners[_winners.Count - 1].PlayerHand.ClosestValue !=
					_winners[_winners.Count - 2].PlayerHand.ClosestValue)
				{
					for (int i = 0; i < _winners.Count - 1; i++)
						_winners[i].IncLooses(false, _dealedCards);

					_winners[_winners.Count - 1].IncWins(false, _dealedCards);
				}
				else
				{
					bool _dealerHighest = _dealer.PlayerHand.ClosestValue == _winners[_winners.Count - 1].PlayerHand.ClosestValue;
					if (_dealerHighest)
						_dealer.IncWins(false, _dealedCards);

					for (int i = _winners.Count - 1; i >= 0; i--)
					{
						if (_winners[i] == _dealer)
							continue;

						if (_winners[i].PlayerHand.ClosestValue == _winners[_winners.Count - 1].PlayerHand.ClosestValue &&
							!_dealerHighest)
							_winners[i].IncDraws(_dealedCards);
						else
							_winners[i].IncLooses(false, _dealedCards);
					}
				}
			}
		}

		#endregion

		#region "Dealer"

		PlayerStatus _dealer;

		public IPlayer Dealer
		{
			get { return _dealer == null ? null : _dealer.Player; }
			set
			{
				if (Status != GameStatus.Stopped)
					throw new Exception("To change the dealer game must be stopped");

				IPlayer oldDealer = _dealer == null ? null : _dealer.Player;

				if (_dealer != null)
					RemovePlayer(_dealer.Player, true);

				_dealer = new PlayerStatus(value, true);
				_players.Add(_dealer);

				RaiseOnDealerChanged(oldDealer, value);
			}
		}

		#endregion

		#region "Deck"

		Deck _deck;
		List<int> _dealedCards = new List<int>();

		private void InitDeck()
		{
			_deck = new Deck(_numberOfDecks);
			_dealedCards.Clear();
		}

		private int _numberOfDecks = 6;

		public int NumberOfDecks
		{
			get { return _numberOfDecks; }
			set
			{
				if (Status != GameStatus.Stopped)
					throw new Exception("To change number of decks game must be stopped");

				_numberOfDecks = value > 0 ? value : 1;
			}
		}

		#endregion

		#region "Players List"

		List<PlayerStatus> _players = new List<PlayerStatus>();

		public void AddPlayer(IPlayer player)
		{
			if (Status != GameStatus.Stopped)
				throw new Exception("To add player game must be stopped");

			_players.Add(new PlayerStatus(player, false));

			RaiseOnPlayerAdded(player, false);
		}

		public bool RemovePlayer(string playerName)
		{
			for (int i = 0; i < _players.Count; i++)
			{
				if (_players[i].Player.Name == playerName)
				{
					if (_players[i].IsDealer)
						throw new Exception("Cannot remove dealer");

					IPlayer removed = _players[i].Player;
					bool isDealer = _players[i].IsDealer;
					_players.RemoveAt(i);

					RaiseOnPlayerRemoved(removed, isDealer);

					return true;
				}
			}

			return false;
		}

		public bool RemovePlayer(IPlayer player)
		{
			if (Status != GameStatus.Stopped)
				throw new Exception("To remove player game must be stopped");

			return RemovePlayer(player, false);
		}

		protected bool RemovePlayer(IPlayer player, bool isDealer)
		{
			for (int i = 0; i < _players.Count; i++)
			{
				if (_players[i].Player == player)
				{
					if (_players[i].IsDealer != isDealer)
						throw new Exception("Cannot remove dealer");

					_players.RemoveAt(i);

					RaiseOnPlayerRemoved(player, isDealer);

					return true;
				}
			}

			return false;
		}

		public void ClearPlayers()
		{
			if (Status != GameStatus.Stopped)
				throw new Exception("To remove all players game must be stopped");

			_players.Clear();
			_dealer = null;

			RaiseOnPlayerListCleared();
		}

		public List<PlayerStatus> Players
		{
			get { return new List<PlayerStatus>(_players); }
		}

		#endregion

		#region "Events"

		public event GameStatusChangeDelegate OnStatusChanged;

		protected void RaiseOnStatusChanged()
		{
			if (OnStatusChanged == null)
				return;

			OnStatusChanged(_status);
		}

		public event EndOfRoundDelegate OnRoundEnd;

		protected void RaiseOnRoundEnd()
		{
			if (OnRoundEnd == null)
				return;

			OnRoundEnd(_currentRound, _players);
		}

		public event EndOfRoundDelegate OnGameEnd;

		protected void RaiseOnGameEnd()
		{
			if (OnGameEnd == null)
				return;

			OnGameEnd(_currentRound, _players);
		}

		public event PlayerListChangeDelegate OnPlayerAdded;

		protected void RaiseOnPlayerAdded(IPlayer player, bool isDealer)
		{
			if (OnPlayerAdded == null)
				return;

			OnPlayerAdded(player, isDealer);
		}

		public event PlayerListChangeDelegate OnPlayerRemoved;

		protected void RaiseOnPlayerRemoved(IPlayer player, bool isDealer)
		{
			if (OnPlayerRemoved == null)
				return;

			OnPlayerRemoved(player, isDealer);
		}

		public event PlayerListClearedDelegate OnPlayerListCleared;

		protected void RaiseOnPlayerListCleared()
		{
			if (OnPlayerListCleared == null)
				return;

			OnPlayerListCleared();
		}

		public event DealerChangeDelegate OnDealerChanged;

		protected void RaiseOnDealerChanged(IPlayer oldDealer, IPlayer newDealer)
		{
			if (OnDealerChanged == null)
				return;

			OnDealerChanged(oldDealer, newDealer);
		}

		#endregion
	}
}
