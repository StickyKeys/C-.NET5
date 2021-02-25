using System;
using static System.Console;

namespace Exercise02
{
    public class Rectangle : Shape
    {
        
        public Rectangle() : base() { }

        public Rectangle(double value) : base(value) {}

        public Rectangle(double height, double width) : base(height, width) {}

        public override string ToString()
        {
            return $"Rectangle H: {this.Height}, W: {this.Width}, Area: {this.Area}";
        }

    
    }
}