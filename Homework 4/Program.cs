using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - Calculate the area of my circle");
            Console.WriteLine("2 - Calculate the area of my square");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("\r\nSelect an option:");

            switch (Console.ReadLine())
            {
                case "1":
                    CircleArea();
                    return true;
                case "2":
                    SquareArea();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        #region Circle Area
         private static string CircleArea()
        {

            Console.Write("Please enter the radius of your circle: ");
            double Radious = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radious * Radious;
            Console.WriteLine("Area of your circle is: " + Area);
            Console.ReadKey();
            return Console.ReadLine();

        }
        #endregion

        #region Square Area
        static string SquareArea()
        {
            Console.Write("Please enter the lengt of the side of your square: ");
            double Line = Convert.ToDouble(Console.ReadLine());
            double AreaSquare = Line * Line;
            Console.WriteLine("Area of your circle is: " + AreaSquare);
            Console.ReadKey();
            return Console.ReadLine();
        }
        #endregion
    }

}
