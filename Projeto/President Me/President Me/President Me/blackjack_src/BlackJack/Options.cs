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
	public partial class Options : Form
	{
		public Options()
		{
			InitializeComponent();
		}

		public DialogResult ShowDialog(bool animate, int animationRefreshRate, int numberOfRounds, int numberOfDecks)
		{
			_animateRoundsCheckBox.Checked = animate;
			_statRefreshingSpin.Value = animationRefreshRate;
			_roundsSpin.Value = numberOfRounds;
			for (int i = 0; i < _decksCombo.Items.Count; i++)
			{
				if (_decksCombo.Items[i].ToString() == numberOfDecks.ToString())
				{
					_decksCombo.SelectedIndex = i;
					break;
				}
			}
			return ShowDialog();
		}


		public bool AnimateGame
		{
			get { return _animateRoundsCheckBox.Checked; }
		}

		public int StatisticRefreshRate
		{
			get { return (int)_statRefreshingSpin.Value; }
		}

		public int NumberOfRoundsPerGame
		{
			get { return (int)_roundsSpin.Value; }
		}

		public int NumberOfDecks
		{
			get { return int.Parse((string)_decksCombo.SelectedItem); }
		}
	
	}
}