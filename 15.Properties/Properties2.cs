using System;  
namespace PropertyExample  
{  
    public class Voter  
    {      
        private int mAge = 0;          
        public int Age  
        {  
           get  
            {  
                return mAge;  
            }  
           set  
            {  
                if (value >= 18)  
                {  
                    mAge = value;  
                }  
               else  
                {  
                    Console.WriteLine("You are not eligible for voting");         
                }  
            }  
        }  
    }  
}  



using System;  
namespace PropertyExample  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Voter objVoter = new Voter();  
            Console.WriteLine("Please enter your age");  
            objVoter.Age = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Your age is :{0} years", objVoter.Age);  
            Console.ReadKey();  
        }  
    }  
}  