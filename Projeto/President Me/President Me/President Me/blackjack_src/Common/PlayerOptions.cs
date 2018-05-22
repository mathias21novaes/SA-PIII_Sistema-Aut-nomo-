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
        Draw,
		Looser,
		LooserBusted
	}
}
