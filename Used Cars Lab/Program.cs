using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;

namespace Used_Cars_Lab
{
    internal class Program
    {
        static void Main()
        {
            Car c = new Car("Toyota", "RAV4", 2022, 30000);
            //Since I've overridden ToString I can do the following:
            Console.WriteLine(c);

            List<Car> inventory = new List<Car>();
            inventory.Add(c);
            inventory.Add(new Car("Ford", "Tundra", 2000, 2100));
            inventory.Add(new Car("Clown", "Buggie", 1590, 10));
            inventory.Add(new UsedCar("Chevrolet", "Nova", 1984, 800, 100000));
            inventory.Add(new UsedCar("Dodge", "Neon", 2004, 500, 168000));
            inventory.Add(new UsedCar("Honda", "Accord", 2001, 1500, 250000));

            int index = 0;
            foreach (Car car in inventory)
            {
                Console.WriteLine(index + ": " + car);
                index++;
            }

            Console.WriteLine("");
            Console.WriteLine("Which car would you like to purchase? Please select by index.");
            string input = Console.ReadLine();
            int pick = int.Parse(input);


            Console.WriteLine(inventory[pick]);
            inventory.RemoveAt(pick);
            Console.WriteLine("");
            Console.WriteLine("Wonderful! Our financing department will be in touch with you soon!");
            Console.WriteLine("Have a great day!");

            index = 0;
            foreach (Car car in inventory)
            {
                Console.WriteLine(index + ": " + car);
                index++;
            }

        }
    }    
}
