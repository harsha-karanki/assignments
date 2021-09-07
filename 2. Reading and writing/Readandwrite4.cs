using System;

namespace MyApp

{
  class Program
    {
     static void Main(string[] args)
     {
       Console.WriteLine("Enter firstname:");
       string firstName = Console.ReadLine();
       
       Console.WriteLine("Enter lastname:");
       string lastName = Console.ReadLine();
       
       Console.WriteLine("Hello " + firstName + lastName);
       }
     }
   }    
   