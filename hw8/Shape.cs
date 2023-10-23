using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    public abstract class Shape:IComparable<Shape>
    {
        private string name;
        public string Name { get { return name; } }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();

        public abstract double Perimeter();

        public int CompareTo(Shape shape)
        {
            Shape c = shape as Circle;
            Shape s = shape as Square;
            if (c != null)
                return this.Area().CompareTo(c.Area());
            else if (s != null)
                return this.Area().CompareTo(s.Area());
            else
                throw new Exception("Unable to compare two objects");
        }
    }
}
