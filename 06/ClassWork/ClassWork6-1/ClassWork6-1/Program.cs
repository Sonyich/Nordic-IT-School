using System;
using System.Diagnostics.CodeAnalysis;

namespace ClassWork6_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                 int perimeter = int.Parse(Console.ReadLine());
                 Console.WriteLine(perimeter);

             if (perimeter <0)
             {
                 throw new Exception (message: "Invalid input data");
             }
            
            do
            {
                Console.WriteLine("pishi");
                //Console.ReadLine();
            }
            while (Console.ReadLine() != "exit");
            */
            // infinite cicle
            int sum = 0;
            do
            {
                sum = sum + 1;
                Console.WriteLine(sum);
                if (sum >= 100)
                    break;
            } while (true);
            
        }
    }
}
