using System;

namespace operations
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = Convert.ToInt32(Console.ReadLine());
      a++;a--;++a;--a;
      
       Console.WriteLine(a);  
     }
  }
}