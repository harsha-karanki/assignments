using System;
class GFG {

	
	public void Identity(String name, int id)
	{

		Console.WriteLine("Name1 : " + name + ", " + "Id1 : " + id);
	}
	
	
	public void Identity(int id, String name)
	{

		Console.WriteLine("Name2 : " + name + ", " + "Id2 : " + id);
	}

	
	public static void Main(String[] args)
	{

		
		GFG obj = new GFG();

		obj.Identity("Harsha", 1);
		obj.Identity(2, "Vardhan");
	}
}
