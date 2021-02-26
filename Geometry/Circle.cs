using System;
using static System.Console;

namespace Exercise02
{
    [Serializable]
    public class Circle : Shape
    {
        /*
        protected double Radius;
        */
        public Circle() : base() { }

        public Circle(double r, string colour)
        {
            Radius = r;
            this.Area = Math.PI * Math.Pow(Radius, 2);
            Colour = colour; 
        }

        public Circle(double height, double width, string colour) : base(height, width, colour) {}

        public override string ToString()
        {
            return $"{Colour} Circle D: {Radius}, Area: {this.Area}";
        }

        public double Radius {get; set;}

    }
}