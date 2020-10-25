using System;
using System.ComponentModel.DataAnnotations;

namespace Homework6_1
{
    class Program
    {
        static void Main(string[] args)
        {         
            int quantityOfEvenDigitsInNumber = 0;

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter, please, positive number less than 2 000 000: ");
                    Console.ResetColor();
                    string ourNumberAsString = Console.ReadLine();
                    if ((ourNumberAsString[0] == '0') && (ourNumberAsString.Length > 1))
                    {   
                        throw new Exception("You should enter a number.");
                    }
                    int ourNumberAsInt = int.Parse(ourNumberAsString);

                    if (ourNumberAsInt < 0)
                    {
                        throw new Exception("You should enter positive number. ");                       
                    }

                    char[] digitOfNumberArray = ourNumberAsString.ToCharArray();
                    for (int i = 0; i < digitOfNumberArray.Length; i++)
                    {
                        if (digitOfNumberArray[i] == '0' || digitOfNumberArray[i] == '2'
                            || digitOfNumberArray[i] == '4' || digitOfNumberArray[i] == '6'
                            || digitOfNumberArray[i] == '8')
                        {
                            quantityOfEvenDigitsInNumber += 1;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Quantity of even digits in number is: " +
                        quantityOfEvenDigitsInNumber + '\n');
                    quantityOfEvenDigitsInNumber = 0;

                    break;

                }
                catch (FormatException t)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(t.Message + '\n' + "Try once more, please" + '\n');
                    Console.ResetColor();
                }
                catch (OverflowException n)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(n.Message + '\n' + "Try once more, please" + '\n');
                    Console.ResetColor();
                }
                catch (Exception f)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(f.Message + '\n' + "Try once more, please" + '\n');
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("For exit enter any digit, please: ");
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
