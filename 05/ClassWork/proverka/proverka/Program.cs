using System;

namespace proverka
{
    enum Figures : int
    {
        Round = 1,
        Triangle,
        Rectangle,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figures a = Figures.Round;
            Console.WriteLine(a);
        }
    }
}
