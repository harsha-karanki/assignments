using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
          Employeemodel emp = new Employeemodel("001","Harsh","harsha.karanki@gmail.com", "10000.00", "Yes");

          Console.WriteLine("Employee name : {0}", emp.EmpId);
          Console.WriteLine("Employee name : {0}", emp.EmpName);
          Console.WriteLine("Employee name : {0}", emp.EmailId);
          Console.WriteLine("Employee name : {0}", emp.Salary);
          Console.WriteLine("Employee name : {0}", emp.IsEmployeeAvailable);


        }
    }
         
}
