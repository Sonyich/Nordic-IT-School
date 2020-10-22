using System;

namespace Classwork5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            Console.WriteLine(chislo < 50 ? "menshe" : "bolshe ili ravno");
        }
    }
}
