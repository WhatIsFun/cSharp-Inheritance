using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Inheritance
{
    internal class SUV : Car
    {
        string specialTyre;
        string foldableSeats;
        string extandablLegSpace;

        public SUV(string engine, string gearType, string color, int numberOfTyres, int numberOfDoors) : base(engine, gearType, color, numberOfTyres, numberOfDoors)
        {
            this.specialTyre = specialTyre;
            this.foldableSeats = foldableSeats;
            this.extandablLegSpace = extandablLegSpace;
        }
    }
}
