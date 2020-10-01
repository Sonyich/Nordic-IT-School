using System;
using System.Threading;

namespace DemoApplication
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Введите имя");
			string name = Console.ReadLine();
			Thread.Sleep(5000);
			Console.WriteLine($"Hello, {name}!");
			Thread.Sleep(5000);
			Console.WriteLine($"Good Bye, {name}!");
			Console.ReadKey();
		}
	}
}