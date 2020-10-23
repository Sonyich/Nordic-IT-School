using System;

namespace ClassWork6_1
{
    class Program
    {
        static void Main(string[] args)
        {

           
                int perimeter = int.Parse(Console.ReadLine());
                Console.WriteLine(perimeter);
            
            
            
            
            if (perimeter <0)
            {
                throw new Exception (message: "Invalid input data");
            }
        }
    }
}
