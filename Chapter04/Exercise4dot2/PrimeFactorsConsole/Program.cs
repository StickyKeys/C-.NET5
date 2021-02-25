using System;
using static MathStuff.PrimeFactors;
using static System.Console;

namespace PrimeFactorsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            for(int i = 1; i <= 50; i++)
            {
                if(isPrime(i))
                {
                    WriteLine($"{i} is prime");
                }
                else
                {
                    WriteLine($"{i} is composite");
                }
            }
            */
            
            WriteLine(GetPrimeFactors(87));
            
        }
    }
}
