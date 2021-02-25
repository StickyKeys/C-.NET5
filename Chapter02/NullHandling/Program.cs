// Try to understand this better
#nullable enable
using System;

namespace NullHandling
{

    class Address
    {
        public string? Building;
        public string Street = string.Empty; 
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compile error!

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            // Go over this https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references
            // string sentence = null;

            // For "Declaring non-nullable variables and parameters"
            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;

            // Checking for null
            // check that the variable is not null before using it
            if(thisCouldBeNull != null)
            {
                // access a member of thisCouldBeNull
            }

            string authorName = null;

            // the following throws a NullReferenceException
            // int x = authorName.Length;

            // instead of throwing an exception, null is assigned to y
            int? y = authorName?.Length;

            // null-coalescing operator used to assign a variable a specific value instead of null
            // when trying to access the member of a possibly null variable

            var result = authorName?.Length ?? 3;
        }
    }
}
