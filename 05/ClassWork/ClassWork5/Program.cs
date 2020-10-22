using System;

namespace ClassWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key for analysis:");
            //считывается введенный символ
            char c = Console.ReadKey(intercept: true).KeyChar;

            if (char.IsLetterOrDigit(c))
            {
                Console.WriteLine("You entered letter or digit!");
            }
            else
            {
                Console.WriteLine("You pressed a streange key");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
