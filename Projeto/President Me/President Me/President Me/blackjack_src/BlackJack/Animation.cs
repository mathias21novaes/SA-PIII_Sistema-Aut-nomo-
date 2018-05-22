/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
	public class Animation
	{
		public struct AnimationEntry
		{
			private Delegate _method;

			private int _time;

			public int Time
			{
				get { return _time; }
			}

			public AnimationEntry(Delegate method, int time)
			{
				_method = method;
				_time = time;
			}

			public void Run(object[] methodParams)
			{
				_method.DynamicInvoke(methodParams);
			}
		}

		private AnimationEntry[] _frames;
		private int _currentFrame = 0;

		private System.Timers.Timer _timer;
		private long _currentTick = 0;

		private object[][] _framesParameters;

		public Animation(AnimationEntry[] frames, int timerTick)
		{
			_timer = new System.Timers.Timer(timerTick);
			_timer.AutoReset = true;
			_timer.Elapsed += new System.Timers.ElapsedEventHandler(_timer_Elapsed);

			_frames = frames;
		}

		private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			_currentTick++;

			if (_currentTick > _frames[_currentFrame].Time)
			{
				_currentTick = 0;
				_currentFrame++;

				if (_currentFrame == _frames.Length - 1)
					_timer.Stop();

				_frames[_currentFrame].Run(_framesParameters[_currentFrame]);
			}
		}

		public void Play(object[][] framesParameters)
		{
			_framesParameters = framesParameters;

			_currentFrame = 0;
			_currentTick = 0;
			_frames[_currentFrame].Run(_framesParameters[_currentFrame]);

			_timer.Start();
		}

		public void Stop()
		{
			_timer.Stop();
		}
	}
}
