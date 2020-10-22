using System;

namespace Classwork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skok let");
            int yearsOfArenda = int.Parse(Console.ReadLine());


            if (yearsOfArenda > 100)
            {
                return;
            }
            if (yearsOfArenda<30 && yearsOfArenda>0)
            {
                if ((yearsOfArenda%10)>0 && (yearsOfArenda % 10) < 5)
                {
                    Console.WriteLine($"Arenda na {yearsOfArenda} goda");
                }
                else
                {
                    Console.WriteLine($"Arenda na {yearsOfArenda} let");
                }

            }
            else
            {
                Console.WriteLine("che napisal debil");
            }

        }
    }
}
