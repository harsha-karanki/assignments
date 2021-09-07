using System;
class stringdatatypes
{
  static void Main() 
  {
        string str_rep = "Sun Rises in the West";
 
        Console.WriteLine("Sentence Before Replacing : " + str_rep);
 
 
 
        string str_after = str_rep.Replace("West", "East");
 
        Console.WriteLine("Sentence After Replacing : " + str_after);
 
 
 
 
 
        Console.ReadLine();
   
  }
}
