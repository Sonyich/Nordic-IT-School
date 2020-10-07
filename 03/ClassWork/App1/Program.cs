using System;

namespace App1
{
	class Program
	{
		static void Main(string[] args)
		{

			const int fun = 7;
			Console.Write("My best program!");

			string s = "10";
			s.PadLeft(4);
			Console.WriteLine(s.PadRight(4));

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.BackgroundColor = ConsoleColor.DarkGreen;

			Console.SetCursorPosition(left: 10, top: 10);

			//Console.InputEncoding = Encoding.UTF8;
			//Console.OutputEncoding = Encoding.UTF8;

			string[] trees = new string[fun];
			int[] ages = new int[fun];

			Console.WriteLine("Please, enter three names of trees, each on new string");

			for (int i = 0; i < trees.Length; i++)
			{
				trees[i]=Console.ReadLine();
			}

			Console.SetCursorPosition(left: 10, top: 20);

			Console.WriteLine("Please, enter ages of these trees, each on new string");
			for (int i = 0; i < ages.Length; i++)
			{
				ages[i] = int.Parse(Console.ReadLine());
			}


			for (int i= 0;i<ages.Length; i++)
			{
				Console.WriteLine(trees[i] + " " + ages[i]);
			}


			Console.ReadKey();
		}
	}
}
