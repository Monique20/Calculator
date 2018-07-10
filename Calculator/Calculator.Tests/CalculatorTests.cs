using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorKata.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void Calculate_GivenAnEmptyString_ShouldReturn0(string input)
        {
            //Arrange
            var expected = 0;
            Calculator sut = new Calculator();

            //Act
            var actual = sut.Calculate(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calculate_GivenTwoNumbersAndAdditionOperation_ShouldReturnTheSum()
        {
            //Arrange
            var input = "1 + 1";
            var expected = 2;
            Calculator sut = new Calculator();

            //Act
            var actual = sut.Calculate(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
