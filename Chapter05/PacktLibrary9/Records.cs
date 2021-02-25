namespace Packt.Shared
{
    public class ImmutablePerson
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

    }


    /*
        A record functions like an immutable class 
        meaning properties and fields can't be changed
        after instatiation. What can be done is creating 
        a new record off of an old one, changing certain fields
        and properties. There is an example in PeopleApp/Program.cs.
        This functionality is reffered to as non-destructive mutation.
    */

    public record ImmutableVehicle
    {
        public int Wheels { get; init; }
        // or int Wheels;
        public string Color { get; init; }
        // or string Color;
        public string Brand { get; init; }
        // or string Brand;
    }

    public record ImmutableAnimal
    {
        string Name; // i.e. public init-only properties
        string Species;

        public ImmutableAnimal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public void Deconstruct(out string name, out string species)
        {
            name = Name;
            species = Species;
        }
        
    }

    // simpler way to define a record that does the equivalent
    // public data class ImmutableSquare(int height, int Width);
    // HOW DO I GET THIS TO WORK?
}