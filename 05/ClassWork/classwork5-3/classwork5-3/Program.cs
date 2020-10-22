using System;

namespace classwork5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            result = a > b
                ? "A>B" //если правда то это. не действие! а значение переменной
                : "A<=B"//если ложь то это

            Console.WriteLine(result);
            //а моэно так написать
            Console.WriteLine(a > b ? "A>B" : "A<=B");
        }
    }
}
