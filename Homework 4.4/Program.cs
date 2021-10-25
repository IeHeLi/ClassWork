using System;
using System.Linq;

namespace Homework_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 };
            int[] array2 = new int[10];

            array1.CopyTo(array2, 0);

            foreach (int item in array2)
            {
                Console.Write($"{item}, ");
            }

            
            Console.ReadLine();
        }
    }
}
