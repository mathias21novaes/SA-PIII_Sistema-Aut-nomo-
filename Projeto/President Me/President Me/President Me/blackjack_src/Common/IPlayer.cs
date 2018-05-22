/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
	public enum PlayerOptions
	{
		Hit,
		Stand
	}

	public enum PlayerInGameStatus
	{
		Playing,
		Stand
	}

	public enum PlayerEndGameStatus
	{
		Winner,
		WinnerBlackJack,
		Draw,
		Looser,
		LooserBusted
	}

	public interface IPlayer
	{
		// Player's name
		string Name { get; }

		// Called at new round
		// newGame - is it start of whole new game not just new round (whole deck is shuffled)
		// isDealer - indicate if the player has role of dealer
		// dealersFirst card - first dealer's card is visible
		// numberOfDecks - number of deck used to play the game
		void NewRound(bool newGame, bool isDealer, int dealersFirstCard, int numberOfDecks);

		// Called on player's turn
		// Player should answer that hi hits or stands
		// left - number of cards left in decks
        PlayerOptions Turn(int left);

		// Called after player's turn if he answered by hitting
		// Also called twice at the beginning of the round - rules of the game
		// card - card given to the player
		void GiveCard(int card);

		// Called at the end of the round
		// status - status of player at the end of the round (looser, winner...)
		// dealedCards - cards that was dealed to all player in the round
		void EndRound(PlayerEndGameStatus status, List<int> dealedCards);
	}
}
