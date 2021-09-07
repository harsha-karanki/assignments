using System;
					
public class Program
{
	public static void Main()
	{
	
		
		int i,n,sum=0;
	
   Console.Write("Input number of terms : ");
   n= Convert.ToInt32(Console.ReadLine()); 
   
   Console.Write("The odd numbers are :");
   
   for(i=1;i<=n;i++)
   {
     Console.Write("{0} ",i);
     sum+=i;
   }
   Console.Write("The Sum of Natural Number upto {0} terms : {1} ",n,sum);
  }
}