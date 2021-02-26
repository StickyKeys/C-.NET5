using System;
using static System.Console;
using System.Xml.Serialization;

namespace Exercise02
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Square))]
    [Serializable]
    public class Shape
    {

        /*
        protected double Height;
        protected double Width;
        protected double Area;
        */
        public Shape()
        {
            Height = 0;
            Width = 0;
            Area = Height * Width;
            Colour = "White";
        }

        public Shape(double value, string colour)
        {
            Height = value;
            Width = value;
            Area = Height * Width;
            Colour = colour; 
        }

        public Shape(double h, double w, string colour)
        {
            Height = h;
            Width = w;
            Area = Height * Width;
            Colour = colour;
        }

        public override string ToString()
        {
            return $"{Colour} Shape H: {Height}, W: {Width}, Area: {Area}";
        }
        
        public double Height {get; set;}
        public double Width {get; set;}
        public double Area {get; set;}
        public string Colour {get; set;}
    }
}
