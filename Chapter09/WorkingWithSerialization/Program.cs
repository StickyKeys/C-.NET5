using System;
using System.Collections.Generic; // List<T>, HashSet<T>
using System.Xml.Serialization;
using System.IO; // FileStream
using Packt.Shared; // Person
using System.Threading.Tasks;

using static System.Console;
using static System.Environment;
using static System.IO.Path;

using NuJson = System.Text.Json.JsonSerializer;

namespace WorkingWithSerialization
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // create an object graph
            var people = new List<Person>
            {
                new Person(30000M){
                    FirstName = "Alice",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1974, 3, 14)
                },
                new Person(40000M){
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1969, 11, 23)
                },
                new Person(20000M){
                    FirstName = "Charlie",
                    LastName = "Cox",
                    DateOfBirth = new DateTime(1984, 5, 4),
                    Children = new HashSet<Person>
                    {
                        new Person(0M)
                        {
                            FirstName = "Sally",
                            LastName = "Cox",
                            DateOfBirth = new DateTime(2000, 7, 12)
                        }
                    }
                }
            };

            // create object that will format a list of Persons as XML
            var xs = new XmlSerializer(typeof(List<Person>));

            // create a file to write to
            string path = Combine(CurrentDirectory, "people.xml");

            using(FileStream stream = File.Create(path))
            {
                // serialize the object graph to the stream
                xs.Serialize(stream, people);
            }

            WriteLine("Written {0:N0} bytes of XML to {1}",
                      arg0: new FileInfo(path).Length,
                      arg1: path);
            
            WriteLine();

            // Display the serialized object graph
            WriteLine(File.ReadAllText(path));

            using(FileStream xmlLoad = File.Open(path, FileMode.Open))
            {
                // deserialize the contents
                var loadedPeople = (List<Person>)xs.Deserialize(xmlLoad);

                // display the contents
                foreach(Person person in loadedPeople)
                {
                    WriteLine("{0} has {1:N0} children.",
                        person.LastName,
                        person.Children.Count 
                    );
                }
            }

            // JSON STUFF
            // create a file path to the json file
            string jsonPath = Path.Combine(CurrentDirectory, "people.json");

            using(StreamWriter jsonStream = File.CreateText(jsonPath))
            {
                // create an object that will format as JSON
                var jss = new Newtonsoft.Json.JsonSerializer();

                // serialize the people to the json file
                jss.Serialize(jsonStream, people);
            }

            WriteLine();
            WriteLine("Written {0:N0} bytes of JSON to: {1}",
                      new FileInfo(jsonPath).Length, jsonPath);

            // Display the serialized object graph
            WriteLine(File.ReadAllText(jsonPath));

            // open json file to deserialize
            using(FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
            {
                // deserialize object graph into a list of person
                var loadedPeople = (List<Person>)

                await NuJson.DeserializeAsync(
                    utf8Json: jsonLoad,
                    returnType: typeof(List<Person>)
                );

                foreach(var item in loadedPeople)
                {
                    WriteLine("{0} has {1} children.",
                    item.LastName, item.Children?.Count ?? 0);
                }
            }
        }
    }
}
