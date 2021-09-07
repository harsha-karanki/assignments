using System;

namespace operations
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(" X = ");
      int X = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine(" Y = ");
      int Y = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(X == Y);  
      Console.WriteLine(X > Y);
      Console.WriteLine(X < Y);
      Console.WriteLine(X >= Y);
      Console.WriteLine(X <= Y);
      Console.WriteLine(X != Y);
     }
  }
}