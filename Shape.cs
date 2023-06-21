using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Inheritance
{
    internal class Shape
    {
        public string color;
        public double area;

        public Shape(string color, double area) 
        {
            this.color = color;
            this.area = area;
        }

    }
    internal class Rectangle : Shape
    {
        public double w; // Width
        public double h; // Height

        public Rectangle(string color, double area, double w, double h) : base(color, area)
        {
            this.w = w;
            this.h = h;
        }
        public double CalArea()
        {
            return w * h;
        }

    }
}
