using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            // while loop
            while(x < 10)
            {
                WriteLine(x);
                x++;
            }

            // do while loop
            string password = string.Empty;
            int attempts = 0;

            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                attempts += 1;
            }
            while(password != "Pa$$w0rd" & attempts < 10);

            if(attempts <= 10){
                WriteLine("Correct!");
            }
            else{
                WriteLine("Too many attempts, your are now locked out...");
            }

            // for loop
            for(int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }

            /// test for loop
            for( ; x < 2; );
            

            // foreach loop
            string[] names = {"Adam", "Barry", "Charlie"};

            foreach(string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }

            /*
                Foreach works on an item that has these three properties
                1. An object is returned from a method applied to the item 
                called GetEnumerator()
                2. The returned object must have a member called Current and
                a method called MoveNext()
                3. MoveNext() returns the next value in an item or returns false
                if there are no more values

                Here is a demonstration of how foreach works under the hood essentially

                IEnumerator e = names.GetEnumerator()

                while(e.MoveNext())
                {
                    string name = (string)e.Current; // Current is read-only!
                    WriteLine($"{name} has {name.Length} characters.");
                }
            
            */
            
        }
    }
}
