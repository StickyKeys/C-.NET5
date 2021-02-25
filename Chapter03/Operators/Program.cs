using static System.Console;
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = a++;

            WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c;

            WriteLine($"c is {c}, d is {d}");

            // Binary arithmetic operators

            int e = 11;
            int f = 3;
            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g / f}");

            // arithmetic assignment operators
            int p = 3;
            p += 3; // equivalent to p = p + 3
            p -= 3; // equivalent to p = p - 3
            p *= 3; // equivalent to p = p * 3
            p /= 3; // equivalent to p = p / 3
        }
    }
}
