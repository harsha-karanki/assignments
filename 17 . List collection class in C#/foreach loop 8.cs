using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
	string[] animals = { "Cow", "Camel", "Elephant" , "Dog" , "Tiger" };  
 
	List<string> animalsList = new List<string>();  
	 animalsList.AddRange(animals);  
	foreach (string a in animalsList) 
	Console.WriteLine(a); 
	}
}