using System;

namespace Projects
{
    public class Employeemodel
    {
       public int EmpId { get; set; }
       public string EmpName { get; set; }
       public string EmailId { get; set; }
       public decimal Salary { get; set; }
       public bool IsEmployeeAvailable { get; set; }



       public Employeemodel(int EmpId, string EmpName, String EmailId, decimal Salary, Bool IsEmployeeAvailable)
       {
         EmpId = EmpId;
         EmpName = EmpName;
         EmailId = EmailId;
         Salary = Salary;
         IsEmployeeAvailable = IsEmployeeAvailable;
       }
       public decimal Salary 
       {
           get { return salary;}
           set
           {
               if (value >=0)
               Salary = value;
           }
       }
    }
}
