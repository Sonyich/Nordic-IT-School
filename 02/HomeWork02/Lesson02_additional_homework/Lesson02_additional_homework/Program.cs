using System;

namespace Lesson02_additional_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers and operation (+,-,*, /,% or **) : ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0;

            if (operation == "+") {
                result = firstNumber + secondNumber;
            }

            if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }

            if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }

            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("It is forbidden");
                }
                else
                {
                    result = Convert.ToSingle(firstNumber) / Convert.ToSingle(secondNumber);
                }
            }

            if (operation == "%")
            {
                result = firstNumber % secondNumber;
            }

            if (operation == "**")
            {
                double firstNumberToDouble = Convert.ToDouble(firstNumber);
                double secondNumberToDouble = Convert.ToDouble(secondNumber);

                result = Math.Pow(firstNumberToDouble, secondNumberToDouble);
            }

            Console.WriteLine("Result is: {0}", result);
        }
    }
}
