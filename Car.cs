using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Inheritance
{
    internal class Car
    {
        string engine;
        string gearType;
        string color;
        int numberOfTyres;
        int numberOfDoors;

        public Car(string engine, string gearType, string color, int numberOfTyres, int numberOfDoors) 
        {
            this .engine = engine;
            this .gearType = gearType;
            this .color = color;
            this .numberOfTyres = numberOfTyres;
            this .numberOfDoors = numberOfDoors;
        }
    }
}
