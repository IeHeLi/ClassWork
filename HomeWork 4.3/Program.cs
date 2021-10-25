using System;
using System.Linq;

namespace HomeWork_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            
   
            int[] testArray = { 1, 2, 3, 4, 5};
            int sum = 0;
            for (int i = 0; i < testArray.Length; i++)
                sum += testArray[i];
            Console.WriteLine($"Sum = {sum}");
            Console.ReadLine();


                string[] stringArray = { "name", "surname" };
            double[] doubleArray = { 2.3, 22, 3.4 };
            #endregion

            #region Loop
            for (int i = 0; i < testArray.Length; i++)
            { 
                Console.WriteLine($"For loop iteration number: {testArray[i]}");
                
                //break;
            }

            string b = stringArray[1];
            Console.WriteLine($"The second element is: {b}" );

            #endregion

            #region ClassWork1
            int[,] array = { { 11, 23, 44 }, { 34, 422, 332 } };
            for (int i = 0; i <2; i++)
            {
                for (int j=0; j <3; j++)
                {
                    Console.WriteLine(array[i,j]);
                }
            }

            #endregion
            int[] arr1 = new int[5];
            for (int i =0; i <5; i++)
            {
                arr1[i] = i++;
                Console.WriteLine(arr1[i]);
            }

            static void FindMaxNumber()
            {
                int[] intArray = { 123123213, 231223, 2222, 34334 };
                var biggestVal = intArray.Max();
                var smallestVal = intArray.Min();

            }
        }
    }
}
