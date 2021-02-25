using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Outputs number of bytes in memory that each of the following
                number types uses, and the minimum and maximum values 
                they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double,
                and decimal
            */
            //Console.WriteLine((string)double.MaxValue);
            
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "Type", "Bytes", "Minimum Value", "Maximum Value");
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "short", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "int", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "long", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "float", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "double", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("{0,-7} {1,5} {2,30} {3,30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            
            // Console.WriteLine($"{sizeof(sbyte),20}{"********",5}{'A',30}");
        }
    }
}
