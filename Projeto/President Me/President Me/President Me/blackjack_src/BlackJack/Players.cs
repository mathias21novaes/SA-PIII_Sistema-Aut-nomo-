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

namespace BlackJack
{
	public partial class Players : Form
	{
		public Players()
		{
			InitializeComponent();

			RefreshPlayerList();

			RefreshDealersName();

			RefreshModuleList();
		}

		private void RefreshDealersName()
		{
			_dealerNameText.Text = Program.TheGame.Dealer.Name;
		}

		private void RefreshModuleList()
		{
			_playerModulesList.Clear();

			foreach (string modules in Game.PlayersDirectory.Instance.LoadedPlayerAssemblies)
				_playerModulesList.Items.Add(modules);
		}

		private void RefreshPlayerList()
		{
			_inGamePlayersList.Clear();

			foreach (Game.PlayerStatus player in Program.TheGame.Players)
				_inGamePlayersList.Items.Add(player.Player.Name);
		}

		private void _removeFromGameButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (_inGamePlayersList.SelectedIndices != null)
				{
					foreach (int i in _inGamePlayersList.SelectedIndices)
						Program.TheGame.RemovePlayer(_inGamePlayersList.Items[i].Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				RefreshPlayerList();
			}
		}

		private void _addModuleButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (_openPlayersModuleDialog.ShowDialog() == DialogResult.OK)
				{
					Game.PlayersDirectory.Instance.LoadPlayer(_openPlayersModuleDialog.FileName);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				RefreshModuleList();
			}
		}

		private void _removeModuleButton_Click(object sender, EventArgs e)
		{
			try
			{

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void _addToGameButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (_playerModulesList.SelectedIndices == null)
					return;

				foreach (int i in _playerModulesList.SelectedIndices)
				{
					Common.IPlayer player =  Game.PlayersDirectory.Instance.CreateInstanceOfPlayer(_playerModulesList.Items[i].Text);
					Program.TheGame.AddPlayer(player);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				RefreshPlayerList();
			}
		}

		private void _setAsDealerButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (_playerModulesList.SelectedIndices == null)
					return;

				if (_playerModulesList.SelectedIndices.Count > 1)
					throw new Exception("Please select only one module");

				Program.TheGame.Dealer = 
					Game.PlayersDirectory.Instance.CreateInstanceOfPlayer(
					_playerModulesList.Items[_playerModulesList.SelectedIndices[0]].Text);

				RefreshDealersName();
				RefreshPlayerList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}