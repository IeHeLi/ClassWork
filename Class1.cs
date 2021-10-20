using System;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
        {
			Console.Write("Please enter the radius of your circle: ");
			double Radious = Convert.ToDouble(Console.ReadLine());
			double Area = Math.PI * Radious * Radious;
			Console.WriteLine("Area of your circle is: " + Area);
			Console.ReadKey;


        }
	}
}
