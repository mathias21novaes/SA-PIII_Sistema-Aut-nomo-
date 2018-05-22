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
using System.Diagnostics;

namespace HumanPlayer
{
	delegate DialogResult ShowModalDialogDelegate(Form form);

	public partial class PlayerForm : Form
	{
		public PlayerForm()
		{
			InitializeComponent();
		}

		public DialogResult ShowDialog(string playerName, List<int> cards)
		{
			string d = string.Empty;
			foreach (int c in cards)
			{
				string s = c.ToString();
				switch (c)
				{
					case 1:
					case 11:
						s = "A";
						break;

					case 12:
						s = "J";
						break;

					case 13:
						s = "Q";
						break;

					case 14:
						s = "K";
						break;

					default:
						s = s.ToString();
						break;					
				}

				d += s + " ";
			}

			Text = playerName;
			_cards.Text = d;
			Form mainFrm = (Form)Form.FromHandle(Process.GetCurrentProcess().MainWindowHandle);
									  
			return ShowModalDialog(mainFrm);
		}

		private DialogResult ShowModalDialog(Form form)
		{
			if (form == null)
				return ShowDialog();

			if (form.InvokeRequired)
			{
				object ret = form.Invoke(new ShowModalDialogDelegate(ShowModalDialog), new object[] { form });

				return (DialogResult)ret;
			}

			return ShowDialog(form);
		}
	}
}