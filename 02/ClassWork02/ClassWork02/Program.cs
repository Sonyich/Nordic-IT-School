using System;

namespace ClassWork02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tell yor age, please: ");
            string age = Console.ReadLine();
            int personAge = int.Parse(age);
            Console.Write("After 10 years your  age will be: ");
            Console.WriteLine(personAge + 10);

        }
        
    }
}
