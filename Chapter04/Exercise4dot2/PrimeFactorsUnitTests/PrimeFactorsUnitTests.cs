using System;
using Xunit;
using static MathStuff.PrimeFactors;

namespace PrimeFactorsUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // PRIME FACTORS OF 45

            string actual;
            string expected = "45 = 5 X 3 X 3";

            actual = GetPrimeFactors(45);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            // PRIME FACTORS OF 106

            string actual;
            string expected = "106 = 53 X 2";

            actual = GetPrimeFactors(106);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            // PRIME FACTORS OF 99
            
            string actual;
            string expected = "99 = 11 X 3 X 3";

            actual = GetPrimeFactors(99);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            // PRIME FACTORS OF 1075
            
            string actual;
            string expected = "1075 = 43 X 5 X 5";

            actual = GetPrimeFactors(1075);

            Assert.Equal(expected, actual);
        
        }
    }
}
