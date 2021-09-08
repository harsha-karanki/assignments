using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        List<string> students = new List<string>();

        students.Add("surya");
        students.Add("mahesh");
        students.Add("ravi");
        students.Add("Ntr");
        students.Add("Krishna");
        students.Add("Prakeshraj");
        students.Add("BandlaGanesh");
        students.Add("Kishore");

        Console.WriteLine();
		
				     students.Reverse(1, 4);

        foreach(string student in students)
        {
            Console.WriteLine(student);
        }
		     students.Reverse(1, 4);
		
		
        
 
	}
}