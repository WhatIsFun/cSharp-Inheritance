using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Inheritance
{
    internal class Vehicle
    {
        public string manufacturer;
        public int year;
    }


    internal class Car1 : Vehicle
    {
        public string model;
        public int numberOfDoors;

        
        public Car1(string manufacturer, int year, string model, int numberOfDoors)
        {
            this.model = model;
            this.numberOfDoors = numberOfDoors;
        }
        public void VehicleData()
        {
            Console.WriteLine($"Manufacturer: {manufacturer} " +
                $"Year: {year} " +
                $"Model: {model} " +
                $"Number Of Doors: {numberOfDoors}");
        }
    }
}
