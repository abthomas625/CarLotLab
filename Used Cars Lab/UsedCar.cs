using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Cars_Lab
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }
        //Want to make constructor that passes values up to the parent and
        //add in our additional one
        //Can use the base keyword here, but it takes a different form
        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }
        //Override ToString and add mileage variable
        public override string ToString()
        {
            return base.ToString() + " \tMileage: " + Mileage;
        }
    }
}

