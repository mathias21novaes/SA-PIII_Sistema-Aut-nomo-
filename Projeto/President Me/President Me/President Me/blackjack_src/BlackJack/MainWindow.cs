/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BlackJack
{
	#region "Player's Hand Animation Frame Delegates"

	delegate void RunPlayerAnimationDelegate(List<Game.PlayerStatus> players);
	delegate void ShowPlayerNameFrameDelegate(string playerName);
	delegate void ShowCardsFrameDelegate(int[] cards);
	delegate void ShowSumFrameDelegate(int sum, bool isBalckjack);

	#endregion

	#region "Common Animation Frame Delegates"

	delegate void NoParamSceneFrameDelegate();

	#endregion

	#region "Round Animation Frame Delegates"

	delegate void ShowRoundFrameDelegate(int round);

	#endregion

	public partial class MainWindow : Form
	{
		#region "Constructors"

		public MainWindow()
		{
			InitializeComponent();

			Program.TheGame.OnPlayerAdded += new Game.PlayerListChangeDelegate(TheGame_OnPlayerAdded);
			Program.TheGame.OnPlayerRemoved += new Game.PlayerListChangeDelegate(TheGame_OnPlayerRemoved);
			Program.TheGame.OnPlayerListCleared += new Game.PlayerListClearedDelegate(TheGame_OnPlayerListCleared);
			Program.TheGame.OnDealerChanged += new Game.DealerChangeDelegate(TheGame_OnDealerChanged);
			Program.TheGame.OnRoundEnd += new Game.EndOfRoundDelegate(TheGame_OnRoundEnd);
			Program.TheGame.OnStatusChanged += new Game.GameStatusChangeDelegate(TheGame_OnStatusChanged);

			try
			{
				string playersError = string.Empty;
				foreach (string player in Game.PlayersDirectory.Instance.LoadedPlayerAssemblies)
				{
					try
					{
						Common.IPlayer playerInstance = Game.PlayersDirectory.Instance.CreateInstanceOfPlayer(player);
						if (Program.TheGame.Dealer == null)
							Program.TheGame.Dealer = playerInstance;
						else
							Program.TheGame.AddPlayer(playerInstance);
					}
					catch
					{
						playersError += "Player: " + player + " coludnot be loaded.\n";
					}
				}

				if (!string.IsNullOrEmpty(playersError))
					MessageBox.Show(playersError, "Error loading some players", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			EnableGameControls(Game.GameStatus.Stopped);

			InitAnimations();
		}

		#endregion

		#region "Animations"

		private bool _animate = true;

		private void InitAnimations()
		{
			Animation.AnimationEntry[] playerFrames = new Animation.AnimationEntry[]
			{
				new Animation.AnimationEntry(new ShowPlayerNameFrameDelegate(ShowPlayerName), 7),
				new Animation.AnimationEntry(new ShowCardsFrameDelegate(ShowCards), 7),
				new Animation.AnimationEntry(new ShowSumFrameDelegate(ShowSum), 20),
				new Animation.AnimationEntry(new NoParamSceneFrameDelegate(PlayerEndScene), 3),
				new Animation.AnimationEntry(new NoParamSceneFrameDelegate(NexPlayer), 1)
			};

			Animation.AnimationEntry[] beginRoundFrames = new Animation.AnimationEntry[]
            {
                new Animation.AnimationEntry(new NoParamSceneFrameDelegate(ShowRound), 10),
                new Animation.AnimationEntry(new NoParamSceneFrameDelegate(RunPlayersAnimations), 1)
            };

			Animation.AnimationEntry[] endRoundFrames = new Animation.AnimationEntry[]
            {
                new Animation.AnimationEntry(new NoParamSceneFrameDelegate(ShowRoundWinner), 20 ),
                new Animation.AnimationEntry(new NoParamSceneFrameDelegate(RoundEndScene), 1)
            };

			_beginRoundAnimation = new Animation(beginRoundFrames, 100);
			_endRoundAnimation = new Animation(endRoundFrames, 100);
			_playerHandAnimation = new Animation(playerFrames, 100);
		}

		private void StopAnimation()
		{
			_playerHandAnimation.Stop();
			_beginRoundAnimation.Stop();
			_endRoundAnimation.Stop();

			_roundLabel.Visible = false;
			_playerNameLabel.Visible = false;
			_sumLabel.Visible = false;
			_winnerNameLabel.Visible = false;

			foreach (Control ctrl in _cardImageControls)
				Controls.Remove(ctrl);

			_cardImageControls.Clear();

			Program.TheGame.AnimationFinished();
		}

		#region "Round Animation"

		Animation _beginRoundAnimation;
		Animation _endRoundAnimation;

		private void ShowRound()
		{
			if (InvokeRequired)
			{
				Invoke(new NoParamSceneFrameDelegate(ShowRound));
				return;
			}

			_winnerNameLabel.Visible = false;

			_roundLabel.Text = "Round " + Program.TheGame.CurrentRound;
			_roundLabel.Visible = true;
		}

		private void ShowRoundWinner()
		{
			if (InvokeRequired)
			{
				Invoke(new NoParamSceneFrameDelegate(ShowRoundWinner));
				return;
			}

			bool isDraw = false;
			string winnerName = string.Empty;
			foreach (Game.PlayerStatus player in Program.TheGame.Players)
			{
				if (player.EndGameStatus == Common.PlayerEndGameStatus.Draw)
				{
					isDraw = true;
					break;
				}
				else if (player.EndGameStatus == Common.PlayerEndGameStatus.Winner ||
					player.EndGameStatus == Common.PlayerEndGameStatus.WinnerBlackJack)
				{
					winnerName = player.Player.Name;
					break;
				}
			}

			if (isDraw)
			{
				_winnerNameLabel.Text = "Game is DRAW";
				_winnerNameLabel.ForeColor = Color.Yellow;
			}
			else
			{
				_winnerNameLabel.Text = "The WINNER is " + winnerName;
				_winnerNameLabel.ForeColor = Color.Red;
			}

			_winnerNameLabel.Visible = true;
		}

		private void RoundEndScene()
		{
			if (InvokeRequired)
			{
				Invoke(new NoParamSceneFrameDelegate(RoundEndScene));
				return;
			}

			_winnerNameLabel.Visible = true;

			Program.TheGame.AnimationFinished();
		}

		#endregion

		#region "Player's Hand Animation"

		private Animation _playerHandAnimation;
		private int _currentPlayerAnimation = 0;

		private List<object[][]> _playersAnimationsParams = new List<object[][]>();

		private void RunPlayersAnimations()
		{
			if (InvokeRequired)
			{
				Invoke(new NoParamSceneFrameDelegate(RunPlayersAnimations));
				return;
			}

			foreach (Game.PlayerStatus player in Program.TheGame.Players)
			{
				UpdatePlayerStatistics(player.Player, player.Wins, player.Draws, player.Looses);

				object[][] animationParams = new object[][]
				{
				    new object[] { player.Player.Name },
				    new object[] { player.PlayerHand.Cards.ToArray() },
				    new object[] { player.PlayerHand.ClosestValue, player.PlayerHand.IsBlackJack },
				    null, null
				};

				_playersAnimationsParams.Add(animationParams);
			}

			_playerHandAnimation.Play(_playersAnimationsParams[0]);
		}

		private void ShowPlayerName(string name)
		{
			if (InvokeRequired)
			{
				Invoke(new ShowPlayerNameFrameDelegate(ShowPlayerName), new object[] { name });
				return;
			}

			_roundLabel.Visible = false;

			_playerNameLabel.Text = "Player: " + name;
			_playerNameLabel.Visible = true;
		}

		private List<PictureBox> _cardImageControls = new List<PictureBox>();
		private Random _randomCardSymbol = new Random();

		private void ShowCards(int[] cards)
		{
			if (InvokeRequired)
			{
				Invoke(new ShowCardsFrameDelegate(ShowCards), new object[] { cards });
				return;
			}

			int totalWidth = cards.Length * CardImage.CARD_WIDTH;

			int hpos = (Width - totalWidth) / 2;

			int i = 0;
			foreach (int card in cards)
			{
				PictureBox pb = new PictureBox();

				pb.Size = new Size(CardImage.CARD_WIDTH, CardImage.CARD_HEIGHT);
				pb.Location = new Point(hpos + i * CardImage.CARD_WIDTH, 180);
				pb.Image = CardImage.LoadCardImage(card, (CardSymbol)_randomCardSymbol.Next(1, 5));

				Controls.Add(pb);

				_cardImageControls.Add(pb);

				i++;
			}
		}

		private void ShowSum(int sum, bool isBalckjack)
		{
			if (InvokeRequired)
			{
				Invoke(new ShowSumFrameDelegate(ShowSum), new object[] { sum, isBalckjack });
				return;
			}

			string str;
			if (isBalckjack)
			{
				str = "BLACKJACK!";
				_sumLabel.ForeColor = Color.Blue;
			}
			else if (sum > Common.Hand.MAX_VALUE)
			{
				str = "BUSTED!";
				_sumLabel.ForeColor = Color.Red;
			}
			else
			{
				str = sum.ToString();
				_sumLabel.ForeColor = Color.Black;
			}

			_sumLabel.Text = str;
			_sumLabel.Visible = true;
		}

		private void PlayerEndScene()
		{
			if (InvokeRequired)
			{
				Invoke(new NoParamSceneFrameDelegate(PlayerEndScene));
				return;
			}

			foreach (PictureBox ctrl in _cardImageControls)
				Controls.Remove(ctrl);

			_cardImageControls.Clear();

			_playerNameLabel.Visible = false;
			_sumLabel.Visible = false;
		}

		private void NexPlayer()
		{
			_currentPlayerAnimation++;

			if (_currentPlayerAnimation == _playersAnimationsParams.Count)
			{
				_playersAnimationsParams.Clear();
				_currentPlayerAnimation = 0;

				object[][] animationParams = new object[][] { null, null };

				_endRoundAnimation.Play(animationParams);
			}
			else
				_playerHandAnimation.Play(_playersAnimationsParams[_currentPlayerAnimation]);
		}

		#endregion

		#endregion

		#region "Game Event Handlers"

		void TheGame_OnStatusChanged(Game.GameStatus status)
		{
			if (InvokeRequired)
			{
				Invoke(new Game.GameStatusChangeDelegate(TheGame_OnStatusChanged), new object[] { status });
				return;
			}

			switch (status)
			{
				case Game.GameStatus.Stopped:
					_currentRoundStatus.Visible = false;

					_progressLabelStatus.Visible = false;
					_gameProgressStatus.Visible = false;

					_gameStatus.ForeColor = Color.Red;
					_gameStatus.Text = "Game Stopped";

					_optionsButton.Enabled = true;
					_optionsMenu.Enabled = true;
					_playersButton.Enabled = true;
					_playersMenu.Enabled = true;

					break;

				case Game.GameStatus.Paused:

					_gameStatus.ForeColor = Color.Yellow;
					_gameStatus.Text = "Game Paused";
					break;

				case Game.GameStatus.Playing:
					_currentRoundStatus.Visible = true;
					_gameProgressStatus.Visible = true;

					_progressLabelStatus.Visible = false;
					_gameProgressStatus.Value = 0;
					_gameProgressStatus.Maximum = Program.TheGame.NumberOfRounds;

					_gameStatus.ForeColor = Color.Green;
					_gameStatus.Text = "Game Running";

					_optionsButton.Enabled = false;
					_optionsMenu.Enabled = false;
					_playersButton.Enabled = false;
					_playersMenu.Enabled = false;

					break;

				default:
					break;
			}

			EnableGameControls(status);
		}

		void TheGame_OnRoundEnd(int currentRound, List<Game.PlayerStatus> players)
		{
			if (InvokeRequired)
			{
				try
				{
					Invoke(new Game.EndOfRoundDelegate(TheGame_OnRoundEnd), new object[] { currentRound, players });
				}
				catch 
				{ } 
				
				return;
			}

			if (!_animate)
			{
				if ((currentRound - 1) % _statisticRefresh == 0)
				{
					foreach (Game.PlayerStatus player in players)
						UpdatePlayerStatistics(player.Player, player.Wins, player.Draws, player.Looses);

					_currentRoundStatus.Text = "Current Round: " + currentRound;
					_gameProgressStatus.Value = currentRound;
				}

				Program.TheGame.AnimationFinished();
			}
			else
			{
				_currentRoundStatus.Text = "Current Round: " + currentRound;
				_gameProgressStatus.Value = currentRound;

				object[][] beginAnimationParams = new object[][] { null, null };

				_beginRoundAnimation.Play(beginAnimationParams);
			}
		}

		void TheGame_OnDealerChanged(Common.IPlayer oldDealer, Common.IPlayer newDealer)
		{
			if (InvokeRequired)
			{
				Invoke(new Game.DealerChangeDelegate(TheGame_OnDealerChanged), new object[] { oldDealer, newDealer });
				return;
			}

			if (oldDealer != null)
				RemovePlayerFromStatistics(oldDealer);

			if (newDealer != null)
				AddPlayerToStatistics(newDealer, true);
		}

		void TheGame_OnPlayerListCleared()
		{
			if (InvokeRequired)
			{
				Invoke(new Game.PlayerListClearedDelegate(TheGame_OnPlayerListCleared));
				return;
			}

			_statistics.Items.Clear();
		}

		void TheGame_OnPlayerRemoved(Common.IPlayer player, bool isDealer)
		{
			if (InvokeRequired)
			{
				Invoke(new Game.PlayerListChangeDelegate(TheGame_OnPlayerRemoved), new object[] { player, isDealer });
				return;
			}

			RemovePlayerFromStatistics(player);
		}

		void TheGame_OnPlayerAdded(Common.IPlayer player, bool isDealer)
		{
			if (InvokeRequired)
			{
				Invoke(new Game.PlayerListChangeDelegate(TheGame_OnPlayerAdded), new object[] { player, isDealer });
				return;
			}

			AddPlayerToStatistics(player, isDealer);
		}

		#endregion

		#region "Statistics Control"

		private int _statisticRefresh = 1000;

		private void AddPlayerToStatistics(Common.IPlayer player, bool isDealer)
		{
			ListViewItem lvi = new ListViewItem(player.Name);
			lvi.SubItems.Add("0");
			lvi.SubItems.Add("0");
			lvi.SubItems.Add("0");

			if (isDealer)
				lvi.ForeColor = Color.Blue;

			_statistics.Items.Add(lvi);
		}

		private void RemovePlayerFromStatistics(Common.IPlayer player)
		{
			for (int i = 0; i < _statistics.Items.Count; i++)
			{
				if (_statistics.Items[i].Text == player.Name)
				{
					_statistics.Items.RemoveAt(i);
					return;
				}
			}
		}

		private void UpdatePlayerStatistics(Common.IPlayer player, int wins, int draws, int looses)
		{
			for (int i = 0; i < _statistics.Items.Count; i++)
			{
				if (_statistics.Items[i].Text == player.Name)
				{
					_statistics.Items[i].SubItems[1].Text = wins.ToString();
					_statistics.Items[i].SubItems[2].Text = draws.ToString();
					_statistics.Items[i].SubItems[3].Text = looses.ToString();

					return;
				}
			}
		}

		#endregion

		#region "Game UI Controls"

		void EnableGameControls(Game.GameStatus status)
		{
			switch (status)
			{
				case Game.GameStatus.Stopped:
					EnableNewGame(true);
					EnableStopGame(false);
					EnablePauseGame(false);
					EnableContinueGame(false);
					break;

				case Game.GameStatus.Paused:
					EnableNewGame(false);
					EnableStopGame(false);
					EnablePauseGame(false);
					EnableContinueGame(true);
					break;

				case Game.GameStatus.Playing:
					EnableNewGame(false);
					EnableStopGame(true);
					EnablePauseGame(true);
					EnableContinueGame(false);
					break;

				default:
					break;
			}
		}

		void EnableNewGame(bool enabled)
		{
			_newGameButton.Enabled = enabled;
			_newGameMenu.Enabled = enabled;
		}

		void EnableStopGame(bool enabled)
		{
			_stopGameButton.Enabled = enabled;
			_stopGameMenu.Enabled = enabled;
		}

		void EnablePauseGame(bool enabled)
		{
			_pauseGameButton.Enabled = enabled;
			_pauseGameMenu.Enabled = enabled;
		}

		void EnableContinueGame(bool enabled)
		{
			_continueGameButton.Enabled = enabled;
			_continueGameMenu.Enabled = enabled;
		}

		#endregion

		#region "Game Control Wrapper"

		private void NewGame()
		{
			try
			{
				Program.TheGame.NewGame();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void StopGame()
		{
			try
			{
				Program.TheGame.StopGame();
				StopAnimation();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void PauseGame()
		{
			try
			{
				Program.TheGame.PauseGame();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ContinueGame()
		{
			try
			{
				Program.TheGame.ContinueGame();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		protected override void OnClosed(EventArgs e)
		{
			try
			{
				Program.TheGame.StopGame();
				StopAnimation();
			}
			catch { }

			base.OnClosed(e);
		}

		#region "Game Menu And Toolbar Events"

		private void _newGameMenu_Click(object sender, EventArgs e)
		{
			NewGame();
		}

		private void _newGameButton_Click(object sender, EventArgs e)
		{
			NewGame();
		}

		private void _stopGameMenu_Click(object sender, EventArgs e)
		{
			StopGame();
		}

		private void _stopGameButton_Click(object sender, EventArgs e)
		{
			StopGame();
		}

		private void _pauseGameMenu_Click(object sender, EventArgs e)
		{
			PauseGame();
		}

		private void _pauseGameButton_Click(object sender, EventArgs e)
		{
			PauseGame();
		}

		private void _continueGameMenu_Click(object sender, EventArgs e)
		{
			ContinueGame();
		}

		private void _continueGameButton_Click(object sender, EventArgs e)
		{
			ContinueGame();
		}

		#endregion

		#region "Players And Options Menu And Toolbar Events"
	
		private void _playersMenu_Click(object sender, EventArgs e)
		{
			Players dlg = new Players();
			dlg.ShowDialog();
		}

		private void _playersButton_Click(object sender, EventArgs e)
		{
			Players dlg = new Players();
			dlg.ShowDialog();
		}

		private void ShowOptionsDialog()
		{
			Options dlg = new Options();

			try
			{
				if (dlg.ShowDialog(_animate, _statisticRefresh, Program.TheGame.NumberOfRounds, Program.TheGame.NumberOfDecks)
					== DialogResult.OK)
				{
					Program.TheGame.NumberOfRounds = dlg.NumberOfRoundsPerGame;
					Program.TheGame.NumberOfDecks = dlg.NumberOfDecks;

					_animate = dlg.AnimateGame;
					_statisticRefresh = dlg.StatisticRefreshRate;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void _optionsMenu_Click(object sender, EventArgs e)
		{
			ShowOptionsDialog();
		}

		private void _optionsButton_Click(object sender, EventArgs e)
		{
			ShowOptionsDialog();
		}

		#endregion

		#region "About Menu And Toolbar Events"
		private void _aboutMenu_Click(object sender, EventArgs e)
		{
			About dlg = new About();
			dlg.ShowDialog(this);
		}

		private void _aboutButton_Click(object sender, EventArgs e)
		{
			About dlg = new About();
			dlg.ShowDialog(this);
		}

		#endregion
	}
}