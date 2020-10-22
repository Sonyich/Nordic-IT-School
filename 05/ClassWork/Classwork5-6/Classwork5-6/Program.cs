using System;

namespace Classwork5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine(int.Parse(Console.ReadLine()) > 50 ? "ggg" : "iii");
           // string str = Console.ReadLine();
            //int a=0;
            /*try 
            { 
                a = int.Parse(str);
                Console.WriteLine($"{a * a}");
            }
            catch (Exception e)
            {
                //e.Message
                Console.WriteLine("oshibka, " +
                    "do 2 mlrd\n "+ e.Message);
                throw;
            }

            */
            try
            {
                Console.WriteLine("Enter integer value A: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter integer value B: ");
                int b = int.Parse(Console.ReadLine());
                int result = a / b;
                Console.WriteLine($"{a} divide by {b} equals to {result}");
            }
            catch (Exception e) // We can specify exception variable to use it later
            {
                Console.WriteLine("Can't continue calculation:");
                Console.WriteLine($"{e.GetType()}: {e.Message}"); // here!
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
