using System;

namespace MyApplication
{
  class Program
  {
    static int PlusMethod(int a, int b)
    {
      return a + b;
      
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the A and B Values: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Sum = " + (a+b));
        Console.WriteLine("Product = " + (a*b));
    }
  }
}
