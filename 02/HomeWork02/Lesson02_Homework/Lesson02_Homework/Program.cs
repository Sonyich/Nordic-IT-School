using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers, please: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of this numbers is: {0}", firstNumber + secondNumber);
            Console.WriteLine("Difference of this numbers is: {0} ", firstNumber - secondNumber);
            Console.WriteLine("Product of this numbers is: {0}", firstNumber * secondNumber);
        }
    }
}