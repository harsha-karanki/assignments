using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
        List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };
		
	        foreach (var el in intList)
        	Console.WriteLine(el);
        }
    }
         
}
