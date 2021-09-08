using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		var numbers = new List<int>(){ 10, 20, 30, 40 };

		numbers.Insert(1, 13);// inserts 11 at 1st index: after 10.
		
		foreach (var num in numbers)
			Console.WriteLine(num);
	}
}