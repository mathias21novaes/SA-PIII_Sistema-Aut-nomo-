/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.Text;
using Common;
using HumanPlayer;

namespace Player
{
	public class MyPlayer : IPlayer
	{

		private Hand _myHand = new Hand();

		string _name;
		string IPlayer.Name { get { return _name; } }

		void IPlayer.NewRound(bool newGame, bool isDealer, int dealersFirstCard, int numberOfDecks)
		{ _myHand.Restart(); }

		PlayerOptions IPlayer.Turn(int left)
		{
			PlayerForm form = new PlayerForm();
			return form.ShowDialog(_name, _myHand.Cards) == System.Windows.Forms.DialogResult.OK
				? PlayerOptions.Hit
				: PlayerOptions.Stand;
		}

		void IPlayer.GiveCard(int card) { _myHand.Add(card); }

		void IPlayer.EndRound(PlayerEndGameStatus status, List<int> dealedCards) { }

		public MyPlayer(string name) { _name = name; }

		public MyPlayer() { _name = "human player " + GetHashCode().ToString(); }
	}
}
