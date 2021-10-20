using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    class Class1
    {
        static void Main(string[] args)
        {
            
            #region MonthTest
            Console.WriteLine("Please input the month: ");
            decimal value = decimal.Parse(Console.ReadLine());
            string longMonth = "This month has 31 days!";
            string mediumMonth = "This month has 30 days!";
            string shortMonth = "This month has 28 days!";

            if (value > 12 || value == 0 || value < 0)
            { 
                Console.WriteLine(" This month doesn't exist. Please input number 1-12");
                
            }
            else 
            {
                switch (value)
                {
                    case 1:
                        Console.WriteLine(longMonth);
                        break;

                    case 2:
                        Console.WriteLine(shortMonth);
                        break;

                    case 3:
                        Console.WriteLine(longMonth);
                        break;

                    case 4:
                        Console.WriteLine(mediumMonth);
                        break;

                    case 5:
                        Console.WriteLine(longMonth);
                        break;

                    case 6:
                        Console.WriteLine(mediumMonth);
                        break;

                    case 7:
                        Console.WriteLine(longMonth);
                        break;

                    case 8:
                        Console.WriteLine(longMonth);
                        break;

                    case 9:
                        Console.WriteLine(mediumMonth);
                        break;

                    case 10:
                        Console.WriteLine(longMonth);
                        break;

                    case 11:
                        Console.WriteLine(mediumMonth);
                        break;

                    case 12:
                        Console.WriteLine(longMonth);
                        break;
                }
            }
            Console.ReadLine();
            #endregion

            #region Conversion 
            Console.WriteLine("Please input your number: ");
            decimal ourNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Absolute value of {ourNumber} is {Math.Abs(ourNumber)} !");
            Console.ReadLine();

            #endregion

            #region LeapYear
            Console.WriteLine("What is the year you want to check? Please input it here: ");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) Console.WriteLine($"{year} is a Leap Year.");
            else Console.WriteLine($"{year} not a Leap Year.");
            Console.ReadLine();
            #endregion

            
        }
    } 
}
