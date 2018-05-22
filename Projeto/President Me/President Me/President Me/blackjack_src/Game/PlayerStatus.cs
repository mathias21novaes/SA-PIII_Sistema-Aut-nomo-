/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.Text;

using Common;

namespace Game
{
	public class PlayerStatus
	{
		#region "Player"

		private IPlayer _player;

		public IPlayer Player
		{
			get { return _player; }
		}

		#endregion

		#region IsDealer

		private bool _isDealer;

		public bool IsDealer
		{
			get { return _isDealer; }
		}

		#endregion

		#region "In Game Status"

		private PlayerInGameStatus _inGameStatus;

		public PlayerInGameStatus InGameStatus
		{
			get { return _inGameStatus; }
			set
			{
				_inGameStatus = value;
			}
		}

		#endregion

		#region "End Game Status"

		private PlayerEndGameStatus _endGameStatus;

		public PlayerEndGameStatus EndGameStatus
		{
			get { return _endGameStatus; }
			set { _endGameStatus = value; }
		}

		#endregion

		#region "Hand"

		private Hand _playerHand = new Hand();

		public Hand PlayerHand
		{
			get { return _playerHand; }
		}

		#endregion

		#region "Statistics"

		private int _playedGames;

		public int PlayedGames
		{
			get { return _playedGames; }
		}

		private int _wins;

		public int Wins
		{
			get { return _wins; }
		}

		private int _looses;

		public int Looses
		{
			get { return _looses; }
		}

		private int _draws;

		public int Draws
		{
			get { return _draws; }
		}

		public void ClearStatistics()
		{
			_wins = _looses = _draws = _playedGames = 0;
		}

		public int IncWins(bool balckjack, List<int> dealedCards)
		{
			_endGameStatus = balckjack ? PlayerEndGameStatus.WinnerBlackJack : PlayerEndGameStatus.Winner;
			_playedGames++;
			_player.EndRound(_endGameStatus, new List<int>(dealedCards));
			return ++_wins;
		}

		public int IncLooses(bool busted, List<int> dealedCards)
		{
			_endGameStatus = busted ? PlayerEndGameStatus.LooserBusted : PlayerEndGameStatus.Looser;
			_playedGames++;
			_player.EndRound(_endGameStatus, new List<int>(dealedCards));
			return ++_looses;
		}

		public int IncDraws(List<int> dealedCards)
		{
			_endGameStatus = PlayerEndGameStatus.Draw;
			_playedGames++;
			_player.EndRound(_endGameStatus, new List<int>(dealedCards));
			return ++_draws;
		}

		#endregion

		#region "Constructors"

		public PlayerStatus(IPlayer player, bool isDealer)
		{
			_player = player;
			_isDealer = isDealer;
			ClearStatistics();
		}

		#endregion

		#region "Game"

		public void NewRound(bool newGame, bool isDealer, int dealersFirstCard, int numberOfDecks)
		{
			_inGameStatus = PlayerInGameStatus.Playing;
			_playerHand.Restart();
			_player.NewRound(newGame, isDealer, dealersFirstCard, numberOfDecks);
		}

		public void GiveCard(int card)
		{
			_player.GiveCard(card);
			_playerHand.Add(card);
		}

		#endregion
	}
}
