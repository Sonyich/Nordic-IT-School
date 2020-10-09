using System;

namespace App1
{
	class Program
	{
		static void Main(string[] args)
		{
	     	 string[] names = new string[3];
	         int[] ages = new int[3];
	      
    		Console.WriteLine("Enter three names:");
    		names[0] = Console.ReadLine();
    		names[1] = Console.ReadLine();
    		names[2] = Console.ReadLine();
    
    		Console.WriteLine("Enter ages of these person:");
    		ages[0]=int.Parse(Console.ReadLine());
    		ages[1]=int.Parse(Console.ReadLine());
    		ages[2]=int.Parse(Console.ReadLine());
    
    for (int i=0; i<names.Length;i++){
        Console.WriteLine("Name: " + names[i]+ ", age in 4 years: " +(ages[i]+4));
    }
    
    Console.ReadKey();
    
    
  }
}
}
