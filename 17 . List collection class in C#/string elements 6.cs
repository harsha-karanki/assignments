using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		
		var cities = new List<string>();
		cities.Add("New York");
		cities.Add("London");
		cities.Add("Mumbai");
		cities.Add("Chicago");
		cities.Add(null); 
		
		Console.WriteLine("String list: " + cities.Count);
		
	}
}

class Student{
	public int Id { get; set; }
	public string Name { get; set; }
}