using System;
using static System.Console;

namespace Exercise02
{
    public class Shape
    {
        protected double Height;
        protected double Width;
        protected double Area;
        public Shape()
        {
            Height = 0;
            Width = 0;
            Area = Height * Width;
        }

        public Shape(double value)
        {
            Height = value;
            Width = value;
            Area = Height * Width;
        }

        public Shape(double h, double w)
        {
            Height = h;
            Width = w;
            Area = Height * Width;
        }

        public override string ToString()
        {
            return $"Shape H: {Height}, W: {Width}, Area: {Area}";
        }
    }
}