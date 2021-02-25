using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    // public class Person : System.Object
    // These are two ways to inherit from the
    // class every type inherits from in C#
    // This is usually implicit
    public partial class Person : object
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        // constants
        /*
            Constants are used to define fields that should not change.
            When referencing a constant, the reference is preceded with
            the class name, not the instance name. Also, any assemblies
            that reference the constant must be recompiled if the original file
            with constant is changed. During compile-time, any reference
            to this variable is replaced with the literal value
        */
        public const string Species = "Homo Sapien";

        // read-only fields (can also be static)
        /*
            Read-only is a better choice than constant.
            Read-only is bette because it can be defined
            at run-time. Also, if changes are made to the 
            original file with the read-only file, it will
            be reflected by code that references it.
        */
        public readonly string HomePlanet = "Earth";
        
        public readonly DateTime Instantiated;

        // constructors
        public Person()
        {
            // set default values for fields
            // including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        // a method signature is a list of parameter types
        // that can be passed when calling the method 
        // as well as the type of the return value

        // overloading is useful to make your program
        // appear as if it has less methods (more clean)

        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true
        )
        {
            return string.Format(
                format: "command is {0}, number is {1}, active is {2}",
                arg0: command,
                arg1: number,
                arg2: active
            );
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method

            z = 99;

            x++;
            y++;
            z++;
        }
    }
}
