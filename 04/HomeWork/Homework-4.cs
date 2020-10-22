using System;
using System.Globalization;

namespace App1
{
	class Program
	{
		static void Main(string[] args)
		{
      			const int smallSize = 1;
      			const int mediumSize = 5;
      			const int largeSize = 20;
      			int numberOfSmallContainers;
      			int numberOfMediumContainers;
      			int numberOfLargeContainers;
      			string delimiter = CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator;
		        Console.WriteLine("Здравствуйте! Какой объем сока (в литрах) вам требуется упаковать?");
      			Console.WriteLine($"Если число дробное, то в качестве дробного разделителя используйте '{delimiter}'");
      			float litters = Single.Parse(Console.ReadLine());

     			litters = MathF.Ceiling(litters);
      			int roundedLitters = (int)litters;
      			numberOfLargeContainers = roundedLitters/largeSize;
      			roundedLitters = roundedLitters - numberOfLargeContainers*largeSize;
      			numberOfMediumContainers = roundedLitters/mediumSize;
      			roundedLitters = roundedLitters - numberOfMediumContainers*mediumSize;
      			numberOfSmallContainers = roundedLitters/smallSize;
     			roundedLitters = roundedLitters - numberOfSmallContainers*smallSize;

      			Console.Write($"Вам следует использовать " +
                    $"{numberOfLargeContainers} больших контейнеров,"+
                    $"{numberOfMediumContainers} средних контейнеров " +
                    $"и {numberOfSmallContainers} маленьких контейнеров.");
  	        
    		}
  	}
}
