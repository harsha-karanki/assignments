using System;

namespace Employee
{
  class Program
  {
    static void Main(string[] args)
    {
      Person myObj = new Person();
      myObj.Name = "Harsha";
      Console.WriteLine(myObj.Name);
    }
  }
}


using System;

namespace Employee
{
  class Person
  
    private string name;  // field
    public string Name    // property
    {
      get { return name; }
      set { name = value; }
    }  
  }
}

