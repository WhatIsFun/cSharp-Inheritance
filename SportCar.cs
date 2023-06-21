using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Inheritance
{
    internal class SportCar : Car
    {
        string nitros;
        string specialSeatBelts;
        public SportCar(string engine, string gearType, string color, int numberOfTyres, int numberOfDoors) : base(engine, gearType, color, numberOfTyres, numberOfDoors)
        {
            this.nitros = nitros;
            this.specialSeatBelts = specialSeatBelts;
        }
    }
}
