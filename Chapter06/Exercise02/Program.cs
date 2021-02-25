using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle(3, 4.5);
            WriteLine(r);

            var s = new Square(5);
            WriteLine(s);

            var c = new Circle(2.5);
            WriteLine(c);
        }
    }
}
