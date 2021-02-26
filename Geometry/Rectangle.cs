using System;
using static System.Console;

namespace Exercise02
{
    [Serializable]
    public class Rectangle : Shape
    {
        
        public Rectangle() : base() { }

        public Rectangle(double value, string colour) : base(value, colour) {}

        public Rectangle(double height, double width, string colour) : base(height, width, colour) {}

        public override string ToString()
        {
            return $"{Colour} Rectangle H: {this.Height}, W: {this.Width}, Area: {this.Area}";
        }

    
    }
}