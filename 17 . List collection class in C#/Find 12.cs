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
        foreach(string student in students)
        {
            Console.WriteLine(student);
        }
			 Console.WriteLine("\nExists(Kishore): {0}",
            students.Find(Kishore));
    }

 
    private static bool Kishore(String s)
    {
        return s.ToLower().EndsWith("Kishore");
    }
}
