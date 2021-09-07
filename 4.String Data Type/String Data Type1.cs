    using System;

namespace stringdatatypes

{
  class Program
    {
     static void Main(string[] args)
     
     {
         
    string Str, Revstr = "";  
    int Length;              

    Console.Write("Enter A String : "); 
    Str = Console.ReadLine();           

    Length = Str.Length - 1;            
    

    while (Length >= 0)                
    {

        Revstr = Revstr + Str[Length];  
        Length--;

    }

    Console.WriteLine("Reverse  String  Is  {0}", Revstr); 
    Console.ReadLine(); 
      }
   }    
} 