using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    internal class Square:Shape
    {
        private double side;

        public double Side {  get { return side; } }

        public Square(string name, double side):base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            double area = side * side;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = side*4;
            return perimeter;
        }
    }
}
