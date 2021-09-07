using System;  
namespace staticexample  
{  
    class Program  
    {  
        public static int i;  
        public static void display()  
        {  
            i=10;  
            Console.WriteLine(i);  
        }  
        public void demo()  
        {  
            int j=20;  
            Console.WriteLine(j);  
        }  
  
   
        static void Main(string[] args)  
        {  
            Program obj = new Program();  
            Program.display();  
            obj.demo();  
            Console.Read();  
        }  
    }  
}