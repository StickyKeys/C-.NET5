using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicitly casting (SAFE)
            int a = 10;
            double b = a; // an int can be safely cast into a double
            WriteLine(b);

            // This gives an error
            // Explicitly casting (DANGEROUS CAN LOSE INFO)
            /*
                double c = 9.8;
                int d = c; // compiler gives an error for this line
                WriteLine(d);
            */
            // This is the cast operator: ()
            double c = 9.8;
            int d = (int)c;
            WriteLine(d); // d is 9 losing the .8 part

            // The same rule applies when converting between large 
            // and small int values

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = long.MaxValue;
            // e = 5_000_000_000;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            // Using System.Convert
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}"); 
            // Notice that the result rounds up

            // Does System.Convert round up when decimal value is 0.5 >= and round down otherwise?
            // It uses banker's rounding
            /*
                If decimal value is < 0.5 then round down
                > 0.5 Round up
                If it's = 0.5 then round down if the non-decimal value is even
                and round up if it's odd
            */
            double[] doubles = new[]{9.49, 9.5, 9.51, 10.49, 10.5, 10.51};

            foreach(double n in doubles)
            {
                WriteLine($"ToInt({n}) is {ToInt32(n)}");
            }

            // Taking control of rounding rules
            foreach(double n in doubles)
            {
                WriteLine(
                    format: "Math.Round({0}, 0, MidepointRounding.AwayFromZero) is {1}",
                    arg0: n,
                    arg1: Math.Round(value: n, digits: 2, mode: MidpointRounding.AwayFromZero)
                );
            }

            // Difference between single, double, and float???

            /*
                Most types inherit the ToString() method from the 
                System.Object class. This allows a programmer
                to convert a value to its string format.
                Here are some examples
            */

            int number = 12;
            WriteLine(number.ToString());
            // WriteLine(number);

            bool boolean = true;
            WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            WriteLine(now.ToString());

            object me = new object();
            WriteLine(me.ToString());

            /*
                Video and image data are represented as binary objects.
                Strict binary can be interpreted in multiple ways. Operating systems
                have a way of reading bits stored and network protocols have a way
                of reading bits being transmitted. A universal format that these 
                binary objects can be stored as is a string that is the same across 
                all platforms. Here is an example.

                Two methods: FromBase64String() and ToBase64String()
            */

            // allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            // populate array with random bytes
            (new Random()).NextBytes(binaryObject);
            // The above line makes no sense to me

            WriteLine("Binary Object as bytes:");

            for(int index = 0; index < binaryObject.Length;  index++)
            {
                Write($"{binaryObject[index]:X}");
            }
            WriteLine("");
            WriteLine("");

            // convert to Base64 string and output as text
            string encoded = Convert.ToBase64String(binaryObject);

            WriteLine($"Binary Object as Base64: {encoded}");

            // Parsing is the opposite from ToString() and works
            // for a few types.
            // Here's some examples: 
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");

            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");

            // WHAT IS A STACK TRACE???
            // Use TryParse to avoid errors when parsing from a string
            Write("How many eggs are there? ");
            int count;
            string input = ReadLine();

            if(int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input.");
            }
        }
    }
}
