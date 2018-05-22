/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
	public class Hand
	{
		#region "Constants"
		public static readonly int MAX_VALUE = 21;
		public static readonly int BLACKJACK = 22;
		#endregion

		#region "Constructors"

		public Hand()
		{
			Restart();
		}

		#endregion

		#region "Hand Manipulation"

		public void Restart()
		{
			_cards.Clear();
			_values.Clear();
			_values.Add(0);
		}

		public void Add(int card)
		{
			_cards.Add(card);

			int val, altVal;

			Deck.CardToValue(card, out val, out altVal);

			int oldValuesCount = _values.Count;
			if (val != altVal)
			{
				for (int i = 0; i < oldValuesCount; i++)
					_values.Add(_values[i] + altVal);
			}

			for (int i = 0; i < oldValuesCount; i++)
				_values[i] += val;

			_values.Sort();
		}

		#endregion

		#region "Hand Status"

		public bool IsBlackJack
		{
			get
			{
				return _cards.Count == 2 && _cards[0] == 1 && _cards[1] == 1;
			}
		}

		public bool IsBusted
		{
			get
			{
				return _values[0] > MAX_VALUE;
			}
		}

		// Gets closest value to MAX_VALUE or to BLACKJACK
		// that can be compined by the cards in hand
		public int ClosestValue
		{
			get
			{
				int closest = _values[0];

				foreach (int v in _values)
				{
					if (v == MAX_VALUE)
						return v;

					else if (Math.Abs(MAX_VALUE - v) < Math.Abs(MAX_VALUE - closest))
						closest = v;
				}

				return closest;
			}
		}

		#endregion

		#region "Cards"
		
		private List<int> _cards = new List<int>();

		public List<int> Cards
		{
			get { return _cards; }
		}

		public int CardCount
		{
			get { return _cards.Count; }
		}

		#endregion

		#region "Values"

		private List<int> _values = new List<int>();

		// Values are in sorted decreasing order
		public List<int> Values
		{
			get { return _values; }
		}

		#endregion
	}
}
