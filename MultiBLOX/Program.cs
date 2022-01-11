using System;
using System.Threading;

namespace MultiBLOX
{
	internal class Program
	{
		private static void Main()
		{
			new Mutex(true, "ROBLOX_singletonMutex");
			Console.Title = "MultiBLOX - Yxzl#3829";
			Console.SetWindowSize(80, 20);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Welcome to MultiBLOX. ");
			Console.WriteLine(" ");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("This Programm allows you to run multiple Roblox Clients at the same time. \n\nDon't close this Process or some Clients will be closed aswell. \n\nEach Roblox Client must have a different Account to work. \n\nExplanation: \nRoblox doesn't allow multiple people to play on one Account. ");
			Console.ReadLine();
		}
	}
}
