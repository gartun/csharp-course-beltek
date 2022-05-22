using System;

namespace TasitLib
{
    public class Car
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string color, string model, int year)
        {
            this.Year = year;
            this.Color = color; 
            this.Model = model; 
        }

        public string PrintInfo()
        {
            return $"This car is a/an {this.Color} {this.Model}, manufactured in {this.Year}.";
        }
    }
}
