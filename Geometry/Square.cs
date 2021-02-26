using System;
using static System.Console;

namespace Exercise02
{
    [Serializable]
    public class Square : Shape
    {
        public Square() : base() { }

        public Square(double value, string colour) : base(value, colour) {}

        public override string ToString()
        {
            return $"{Colour} Square H: {this.Height}, W: {this.Width}, Area: {this.Area}";
        }
    }
}