using System;

namespace MyApp

{
  class Program
    {
     static void Main(string[] args)
     
     {
         char letter , letter1 , letter2;
         
      Console.WriteLine("Input letter :" );
      letter = Convert.ToChar(Console.ReadLine());
      
      Console.WriteLine("Input letter1 :" );
      letter1 = Convert.ToChar(Console.ReadLine());
      
      Console.WriteLine("Input letter2 :" );
      letter2 = Convert.ToChar(Console.ReadLine());
      
      Console.WriteLine("{0} {1} {2} ", letter2,letter1,letter);
      
      }
   }    
}      