using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Cars_Lab
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //Empty constructor that sets all above variables to default
        public Car()
        {

        }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
        
        //ToString comes from the Objects class and all classes have it
        //However, by default, without overriding it, ToString returns the type of the object
        //and not its contents, but if we override it then we can customize it.

        //Anytime an object would be turned into a string, its ToString method gets called
        //Which can be handy specifically for printing out the object
        public override string ToString()
        {
            string output = $"Make: {Make}, \tModel: {Model}, \tYear: {Year}, \tPrice: {Price}";
            return output;
        }

    }
}
