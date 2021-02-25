using System;
using Xunit;
using Packt;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        /*
            Three parts to a unit test

            Arrange: Declare and instatiate variables for input and output

            Act: Perform the code such as a function that needs to be tested

            Assert: Establish beliefs about the output that determine 
            whether the code passed or failed the test
        */

        [Fact]
        public void Test1()
        {
            // arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calculator();

            // act
            double actual = calc.Add(a,b);

            // assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding2And3()
        {
            // arrange 
            double a = 2;
            double b = 3;
            double expected = 5; 
            var calc = new Calculator();

            // act 
            double actual = calc.Add(a,b);

            // assert 
            Assert.Equal(expected, actual);
        }
    }
}
