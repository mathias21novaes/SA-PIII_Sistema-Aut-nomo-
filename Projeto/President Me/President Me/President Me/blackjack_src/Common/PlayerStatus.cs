using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
	public class PlayerStatus
	{
		private IPlayer _player;

		public IPlayer Player
		{
			get { return _player; }
		}

		private PlayerInGameStatus _inGameStatus;

		public PlayerInGameStatus InGameStatus
		{
			get { return _inGameStatus; }
			set
			{
				_inGameStatus = value;
				_player.InGameStatus = value;
			}
		}

		private Hand _playerHand = new Hand();

		public Hand PlayerHand
		{
			get { return _playerHand; }
		}

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

		public PlayerStatus(IPlayer player)
		{
			_player = player;
		}

		public void ClearHand()
		{
			_playerHand.Restart();
		}

		public void ClearStatistics()
		{
			_wins = _looses = _draws = _playedGames = 0;
		}

		public int IncWins()
		{
			_playedGames++;
			_player.EndGame(PlayerEndGameStatus.Winner);
			return ++_wins;
		}

		public int IncLooses(bool busted)
		{
			_playedGames++;
			_player.EndGame(busted ? PlayerEndGameStatus.LooserBusted : PlayerEndGameStatus.Looser);
			return ++_looses;
		}

		public int IncDraws()
		{
			_playedGames++;
			_player.EndGame(PlayerEndGameStatus.Draw);
			return ++_draws;
		}
	}
}
