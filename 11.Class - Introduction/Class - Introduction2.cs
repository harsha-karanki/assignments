using System;

namespace class
{
  class Program
  {
    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang", "Red", 1969);
      Car Opel = new Car("Astra", "White", 2005);

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}


using System;

namespace MyApplication
{
  class Car
  {
    public string model;
    public string color;
    public int year;
    
    public Car(string modelName, string modelColor, int modelYear)
    {
      model = modelName;
      color = modelColor;
      year = modelYear;
    }  
  }
}