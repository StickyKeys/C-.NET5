using System;
using static System.Console;

namespace Exercise02
{
    public class Circle : Shape
    {
        protected double radius;
        public Circle() : base() { }

        public Circle(double r)
        {
            radius = r;
            this.Area = Math.PI * Math.Pow(radius, 2);
        }

        public Circle(double height, double width) : base(height, width) {}

        public override string ToString()
        {
            return $"Circle D: {radius}, Area: {this.Area}";
        }
    }
}