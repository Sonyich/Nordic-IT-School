using System;

class MainClass {
  public static void Main (string[] args) 
    {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine ("Hello, everyone! This program prints the multiplication table. You should enter left and right boundaries of this table (the first and the second multipliers). Let`s start?");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine ("Enter two multipliers, please:");

    //считываем границы таблицы
    int firstMultiplier = int.Parse(Console.ReadLine());
    int secondMultiplier = int.Parse(Console.ReadLine());

    //заполняем массив множителей 
    int size = secondMultiplier-firstMultiplier+1;
    int[] table = new int[size];
    for (int i=0;i<size;i++)
      {
      table[i]=firstMultiplier+i;
      }

    //печатаем первую строчку
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("*\t"); 
    for (int i=0;i<size;i++)
      {
      Console.Write((table[i])+"\t");
      }

    Console.WriteLine("\r\n");

    for (int i=0;i<size;i++)
      {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write(table[i]+ "\t");
        for (int j=0;j<size;j++)
        {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(table[i]*table[j]+"\t");
        }
      Console.WriteLine("\r\n");
    }
  }
}
