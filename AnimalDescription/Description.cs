using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDescription
{
    public class Description
    {
        private static void Main(string[] args)
        {
            var animal = new Animal()
            {
                eyeColour = "Blue",
                skinColour = "Black",
                weight = "Heavy",
                height = "Large",
                age = "Old"
            };

            Console.WriteLine($"The eye color of the animal is: {animal.eyeColour}.");
            Console.WriteLine($"The skin color of the animal is: {animal.skinColour}.");
            Console.WriteLine($"The weight of the animal is: {animal.weight}.");
            Console.WriteLine($"The height of the animal is: {animal.height}.");
            Console.WriteLine($"The age of the animal is: {animal.age}.");
            Console.ReadLine();

        }
    }
}
