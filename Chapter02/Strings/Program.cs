using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // let the heightInMetres variable become equal to the value 1.88
            double heightInMetres = 1.88;
            Console.WriteLine("INTERPOLATED STRING EXAMPLE");
            Console.WriteLine($"The variale {nameof(heightInMetres)} has the value {heightInMetres}.\n");
            // The $ sign is used for interpolated strings and allows you to format strings
            // by inserting values from variables
            // nameof can be used to return the name of the variable not its literal value

            // Character literal values use single quotes to wrap the character literal stored in a variable
            // Some examples
            char letter = 'A'; // assigning literal characters
            char digit = '1';
            char symbol = '$';

            // You can also return a character value from a function which can then be assigned to a variable

            // Strings are made up multiple characters (a string of text), the characters are encapsulated in 
            // double quotes to represent a string literal
            // Some examples
            string firstName = "Bob"; // assigning literal strings
            string lastName = "Smith";
            string phoneNumber = "(215) 555-4256";

            // You can also return a string value from a function which can then be assigned to a variable
            

            // There are such things as escape sequences which allows the programmer to define things such as
            // tabs, new line, and other special characters within the string literal
            // Some examples
            string fullNameWithTabSeparator = "Bob\tSmith";
            Console.WriteLine("ESCAPE SEQUENCE EXAMPLE");
            Console.WriteLine(fullNameWithTabSeparator + "\n");

            // There are such things as verbatim literal strings
            // By placing an @ symbol before the double quotes escape sequences are disabled and
            // treated as regular characters
            // Example
            string filePath = @"C:\televisions\sony\bravia.txt";
            Console.WriteLine("VERBATIM STRING EXAMPLE");
            Console.WriteLine(filePath);
        }
    }
}
