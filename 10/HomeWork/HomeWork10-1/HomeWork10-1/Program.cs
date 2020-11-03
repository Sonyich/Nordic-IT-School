using System;
using System.Linq.Expressions;

namespace HomeWork10_1
{
   class Person
    {
        private string _nameOfPerson;
        private byte _age;

        public string NameOfPerson
        {
            get
            {
                return _nameOfPerson;
            }

            set
            {
                foreach (char ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new Exception(message: "It is forbidden. You should use letters for name.");
                        Console.ResetColor();
                    }
                }
                _nameOfPerson = value;
            }
        }

        public byte Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > 130)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Age should be < 130");
                    Console.ResetColor();
                }
                _age = value;
            }
        }

        public int AgeInFourYears
        {
            get
            {
                return _age + 4;
            }
        }

        public string PropertyString
        {
            get
            {
                return $"{NameOfPerson} in 4 years is: {AgeInFourYears}";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];

            for (int i=0; i < persons.Length; i++)
            {
                persons[i] = new Person();
            }

            try
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Please, enter name of the {i + 1} person: ");
                    Console.ResetColor();
                    persons[i].NameOfPerson = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Please, enter age of the {i + 1} person: ");
                    Console.ResetColor();
                    persons[i].Age = byte.Parse(Console.ReadLine());
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                for (int i = 0; i < persons.Length; i++)
                {
                    Console.WriteLine(persons[i].PropertyString);
                }

                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Please, enter any key to exit:");
                Console.ReadKey();
            }

            catch (FormatException n)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(n.Message);
                Console.ResetColor();
            }

            catch (Exception f) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(f.Message);
                Console.ResetColor();
            }
        }
    }
}