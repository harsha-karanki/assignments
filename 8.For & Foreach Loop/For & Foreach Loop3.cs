using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter Array printing using for loop =");
      
      string[] cars = {Console.ReadLine()};
      for (int i = 0; i < cars.Length; i++) 
      {
        Console.WriteLine(cars[i]);
      }
      Console.WriteLine("Enter Array printing using ForEach loop =");
      
      string[] name = {Console.ReadLine()};
     
      
      Array.Sort(name);
      foreach (string i in name)
      {
        Console.WriteLine(i);
      }    
      
     
    }
  }
}