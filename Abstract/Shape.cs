using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract public class Shape
    {
        public abstract void Area();
    }
    public class Circle : Shape
    {

        private int radius;
        private double result;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void Area()
        {
            result = 3.14 * radius * radius;
        }
        public override string ToString()
        {
            return $"Area of Circle is {result}";
        }
    }
    // homework
    public class Rectangle : Shape
    {
        private double l,b;
        private double result;
        public Rectangle(double l,double b)
        {
            this.l = l;
            this.b = b;
        }

        public override void Area()
        {
            result =l*b;
        }
        public override string ToString()
        {
            return $"Area of Rectangle is {result}";
        }
    }

}
