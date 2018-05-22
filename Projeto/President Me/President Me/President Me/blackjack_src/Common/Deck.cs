/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
	public class Deck
	{
		#region "Constants"
		private static readonly int SHUFFLE_COUNT = 7;
		public static readonly int FIRST_CARD = 1;
		public static readonly int LAST_CARD = 14;
		public static readonly int NUMBER_OF_SAME_VALUE_CARDS = 4;
		#endregion

		#region "Constructors"

		public Deck(int numberOfDecks)
		{
			_numberOfDecks = numberOfDecks;
			Restart();
		}

		#endregion

		#region "Deck Manipulation"

		public int TakeCard()
		{
			if (_cards.Count > 0)
			{
				int card = _cards[0];
				_cards.RemoveAt(0);

				return card;
			}
			else
				throw new Exception("No more cards in the deck!");
		}

		// Return cards are shuffled and returned to the end of the deck
		public void ReturnCards(List<int> cards)
		{
			Shuffle(SHUFFLE_COUNT, cards);
			_cards.AddRange(cards);
		}

		public void Restart()
		{
			_cards.Clear();

			for (int i = FIRST_CARD; i <= LAST_CARD; i++)
			{
				if (i == 11)
					continue;

				for (int j = 0; j < NUMBER_OF_SAME_VALUE_CARDS; j++)
				{
					for (int k = 0; k < _numberOfDecks; k++)
						_cards.Add(i);
				}
			}

			Shuffle(SHUFFLE_COUNT, _cards);
		}

		#endregion

		#region "Cards"

		private int _numberOfDecks;

		private List<int> _cards = new List<int>();

		public int NumberOfDecks
		{
			get { return _numberOfDecks; }
		}

		public int CardsLeft
		{
			get { return _cards.Count; }
		}

		#endregion

		#region "Utilities"

		// Return value (and alternative if any) of the card 
		public static void CardToValue(int card, out int value, out int altValue)
		{
			if (card == 1)
			{
				value = 1;
				altValue = 11;

				return;
			}
			else if (card <= 10)
			{
				altValue = value = card;
				return;
			}
			else if (card > 10)
			{
				altValue = value = 10;
				return;
			}

			throw new Exception("There's no such a card!");
		}

		private static Random _random = new Random();

		public static void Shuffle(int times, List<int> cards)
		{
			for (int k = 0; k < times; k++)
			{
				for (int i = 0; i < cards.Count; i++)
				{
					int j = _random.Next(cards.Count - 1);

					int t = cards[i];
					cards[i] = cards[j];
					cards[j] = t;
				}
			}
		}

		#endregion
	}
}
