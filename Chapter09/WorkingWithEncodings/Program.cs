using System;
using System.Text;
using static System.Console;

namespace WorkingWithEncodings
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Encodings");
            WriteLine("[1] ASCII");
            WriteLine("[2] UTF-7");
            WriteLine("[3] UTF-8");
            WriteLine("[4] UTF-16 (Unicode)");
            WriteLine("[5] UTF-32");
            WriteLine("[any other key] Default");

            // choose an encoding
            Write("Press a number to choose an encoding: ");
            ConsoleKey number = ReadKey(intercept: false).Key;
            WriteLine();
            WriteLine();

            Encoding encoder = number switch
            {
                ConsoleKey.D1 => Encoding.ASCII,
                ConsoleKey.D2 => Encoding.UTF7,
                ConsoleKey.D3 => Encoding.UTF8,
                ConsoleKey.D4 => Encoding.Unicode,
                ConsoleKey.D5 => Encoding.UTF32,
                _             => Encoding.Default
            };

            // define a string to encode
            string message = "A pint of milk is £1.99";

            // encode the string into a byte array
            // Aren't there different lengths to different 
            // encoding standards? For example UTF-16 uses at
            // least 16 bits for a character meaning a byte array 
            // only holds values that can utilize at most 8 bits. 
            // Would this cause problems or does it not because the character
            // s being used only use 8 bits. 

            byte[] encoded = encoder.GetBytes(message);
            WriteLine("{0} uses {1:N0} bytes",
                       encoder.GetType().Name, encoded.Length);

            // enumerate each byte
            WriteLine($"BYTE HEX CHAR");
            foreach(byte b in encoded)
            {
                WriteLine($"{b,4} {b.ToString("X"),3} {(char)b,4}");
            }

            // decode the byte array back into a string and display it
            string decoded = encoder.GetString(encoded);
            WriteLine(decoded);
        }
    }
}
