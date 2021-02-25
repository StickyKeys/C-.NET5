using System;
using static System.Console;

namespace Exercise02
{
    public class Square : Shape
    {
        public Square() : base() { }

        public Square(double value) : base(value) {}

        public override string ToString()
        {
            return $"Square H: {this.Height}, W: {this.Width}, Area: {this.Area}";
        }
    }
}