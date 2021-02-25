using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            string output= "";
            for(int i = 1; i <= 100; i++)
            {
               if(i % 5 == 0 && i % 3 == 0)
               {
                   output = "FizzBuzz";
               }
               else if(i % 5 == 0)
               {
                   output = "Buzz";
               }
               else if(i % 3 == 0)
               {
                   output = "Fizz";
               }
               else
               {
                   output = i.ToString();
               }

               if(i == 100)
               {
                   Write(output);
               }
               else
               {
                   Write(output + ", ");
               }
            }
        }
    }
}
