using System;

namespace Classw1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*object i;
			i=int.Parse(Console.ReadLine());
			object j = (int)i + 10;
			Console.WriteLine(Math.Sqrt((int)j));
			*/

			/*object s;
			s = Console.ReadLine();
			Console.WriteLine(((string)s).Length);
			
			dynamic s2;
			s2 = Console.ReadLine();
			Console.WriteLine(s2.Length);


			Console.ReadKey();*/

			/*var A = 3.14f;
			var B = 1D;
			var C=49l;
			var D=(byte)255;

			Console.WriteLine(A.GetType());
			Console.WriteLine(B.GetType());
			Console.WriteLine(C.GetType());
			Console.WriteLine(D.GetType());
			*/

			/*
			int? t = null;
			
		  
			Console.WriteLine(t.Value +" "+ t.HasValue);
			*/

			string[] names = new string[2];

			names[0] = "Andrey";
			names[1] = "Maria";

			string[] names1 = new string[7];
			names1[0] = names[0];

			for (int i=0;i<names.Length;i++)
			{
				Console.WriteLine(names1[i]);
			}






		}
	}
}
