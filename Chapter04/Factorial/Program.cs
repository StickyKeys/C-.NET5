using System;
using static System.Console;

namespace Factorial
{
    class Program
    {
        static int Factorial(int number)
        {
            if(number < 1)
            {
                return 0;
            }

            else if(number == 1)
            {
                return 1;
            }
            else
            {
                checked // for overflow
                {
                    return Factorial(number-1) * number;
                }
            }
        }

        static void RunFactorial()
        {
            for(int i = 1; i < 15; i++)
            {
                try
                {
                    WriteLine($"{i}! = {Factorial(i):N0}");
                }
                catch(System.OverflowException)
                {
                    WriteLine($"{i}! is too big for a 32-bit integer.");
                }
                
            }
        }

        static void Main(string[] args)
        {
            RunFactorial();
        }
    }
}
