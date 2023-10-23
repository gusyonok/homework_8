using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    internal class Circle : Shape
    {
        private double radius;

        public double Radius { get { return radius; } }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            double area = Math.PI*radius*radius;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 2*Math.PI*radius;
            return perimeter;
        }


    }
}
