using System;
					
public class Program
{
	public static void Main()
	{
	
		
		int i,n=0;
	
   Console.Write("Enter number : ");
   
   n= Convert.ToInt32(Console.ReadLine());   
   Console.Write("The even numbers are :");
   for(i=1;i<=n;i++)
   {
     Console.Write("{0} ",2*i);
   }
  }
}