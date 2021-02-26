using System;
using Exercise02;
using System.Collections.Generic;
using System.Xml.Serialization; // XmlSerializer
using System.IO;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle(2.5, "Red"),
                new Rectangle(20.0, 10.0, "Green"),
                new Circle(8.0, "Blue"),
                new Circle(12.3, "Yellow"),
                new Rectangle(45.0, 18.0, "Brown")
            };

            var xs = new XmlSerializer(typeof(List<Shape>));

            string xmlPath = Combine(CurrentDirectory, "shapes.xml");

            using(FileStream stream = File.Create(xmlPath))
            {
                xs.Serialize(stream, shapes);
            }

            // Read all contents
            WriteLine(File.ReadAllText(xmlPath));

            // NOW DESERIALIZE
            using(FileStream loadedXmlShapes = File.Open(xmlPath, FileMode.Open))
            {
                List<Shape> loadedShapes = (List<Shape>)xs.Deserialize(loadedXmlShapes);

                foreach(var shape in loadedShapes)
                {
                    WriteLine(shape);
                }
            }

        }
    }
}
