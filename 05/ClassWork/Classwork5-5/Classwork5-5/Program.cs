using System;
using System.Security.Cryptography.X509Certificates;

namespace Classwork5_5
{
    class Program
    {
        public enum Color { Red, Green, Blue }
        static void Main(string[] args)
        {
            Color c = (Color)(new Random()).Next(0, 3);
            switch(c)
            {
                //не пистаь условий типа больше нуля
                case Color.Red:
                    Console.WriteLine("red");
                    break;
                case Color.Blue:
                    Console.WriteLine("blue");
                    break;
                default:
                    Console.WriteLine("ne znau");
                    break;
            }
        
        }
    }
}
