/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.Text;

using Common;
namespace Player
{
	public class MyPlayer : IPlayer
	{
		private Hand _myHand = new Hand();

		private string _name;
		public string Name { get { return _name; } }

		public void NewRound(bool newGame, bool isDealer, int dealersFirstCard, int numberOfDecks)
		{ _myHand.Restart(); }

		public PlayerOptions Turn(int left)
		{
			if (_myHand.IsBlackJack || _myHand.Values.Contains(21))
				return PlayerOptions.Stand;

			return _myHand.Values[0] <= 17 ? PlayerOptions.Hit : PlayerOptions.Stand;
		}

		public void GiveCard(int card) { _myHand.Add(card); }

		public void EndRound(PlayerEndGameStatus status, List<int> dealedCards) { }

		public MyPlayer(string name) { _name = name; }

		public MyPlayer() { _name = "strange name " + GetHashCode().ToString(); }
	}
}
