using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true){

                Write("Press ESC to end or any key to try again. ");
                ConsoleKeyInfo pressedKey = ReadKey();
                if(pressedKey.Key == ConsoleKey.Escape) return;
                WriteLine();

                Write("Enter a regular expression (or press ENTER to use the default): ");
                string regExpression = ReadLine();

                Write("Enter some input: ");
                string input = ReadLine();

                var checker = new Regex(regExpression);

                Match match = checker.Match(input);

                WriteLine($"{input} matches {regExpression}? {match.Success}");

            }

            

        }
    }
}
