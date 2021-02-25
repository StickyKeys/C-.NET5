using System;
using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Write("Enter a number between 0 and 255: ");
                byte firstOperand = Byte.Parse(ReadLine());
                Write("Enter another number between 0 and 255: ");
                byte secondOperand = Byte.Parse(ReadLine());
                WriteLine($"{firstOperand} divided by {secondOperand} is {firstOperand / secondOperand}");
            }
            catch(Exception ex)
            {
                WriteLine($"{ex.GetType()}: {ex.Message}");
            }
            
        }
    }
}
