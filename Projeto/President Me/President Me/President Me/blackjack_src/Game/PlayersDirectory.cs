/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.Text;

using Common;
using System.Reflection;
using System.IO;

namespace Game
{
	public class PlayersDirectory
	{
		#region "Global Instance Of Players Directory"

		private static PlayersDirectory _instance = new PlayersDirectory();

		public static PlayersDirectory Instance
		{
			get { return _instance; }
		}

		#endregion

		#region "Directory"

		Dictionary<string, Assembly> _directory = new Dictionary<string, Assembly>();

		public List<string> LoadedPlayerAssemblies
		{
			get { return new List<string>(_directory.Keys); }
		}

		#endregion

		#region "Constructors"

		public PlayersDirectory()
		{
			LoadPlayersDirectory();
		}

		#endregion

		#region "Loading Of Assemblies"

		private void LoadPlayersDirectory()
		{
			string playersPath = AppDomain.CurrentDomain.BaseDirectory;
			playersPath = Path.Combine(playersPath, "Players");

			string[] playerFileNames;

			try
			{
				playerFileNames = Directory.GetFiles(playersPath, "*.dll");

				foreach (string fileName in playerFileNames)
				{
					try
					{
						LoadPlayer(fileName);
					}
					catch { }
				}
			}
			catch { }
		}

		public Assembly LoadPlayer(string path)
		{
			Assembly playerAssembly;

			try
			{
				playerAssembly = Assembly.LoadFile(path);
			}
			catch
			{
				throw new Exception("Player's Assembly " + path + " couldn't be loaded");
			}

			bool found = false;
			Type[] types = playerAssembly.GetTypes();
			foreach (Type t in types)
			{
				if (t.FullName == "Player.MyPlayer")
				{
					found = true;
					break;
				}
			}

			if (!found)
				throw new Exception("Assembly is loaded but there is no player in it");

			string key = Path.GetFileNameWithoutExtension(path);

			try
			{
				_directory.Add(key, playerAssembly);
			}
			catch
			{

				throw new Exception("Assembly already exists with name \"" + key + "\"");
			}

			return playerAssembly;
		}

		#endregion

		#region "Creating Of Players Instances"

		public IPlayer CreateInstanceOfPlayer(string playerModuleName)
		{
			Assembly playerAssembly = _directory[playerModuleName];

			if (playerAssembly == null)
				return null;

			try
			{
				IPlayer player = (IPlayer)playerAssembly.CreateInstance("Player.MyPlayer");

				return player;
			}
			catch
			{
				throw new Exception("Error while making of instance of a player");
			}
		}

		public IPlayer CreateInstanceOfPlayer(string playerModuleName, object[] constructorParameters)
		{
			Assembly playerAssembly = _directory[playerModuleName];

			if (playerAssembly == null)
				return null;

			try
			{
				IPlayer player = (IPlayer)playerAssembly.CreateInstance
					("Player.MyPlayer", false, BindingFlags.CreateInstance, null,
					constructorParameters, System.Globalization.CultureInfo.CurrentCulture, null);

				return player;
			}
			catch
			{
				throw new Exception("Error while making of instance of a player");
			}
		}

		#endregion
	}
}
