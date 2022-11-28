namespace UnitTests
{
    using System;
    using System.IO;
    using Calculators;

    using FluentAssertions;

    using Xunit;
    using Xunit.Extensions;
    /* Create simple String calculator with a method int Add(string numbers)
        The method can take 0, 1 or 2 numbers, and will retutn their sum(fir an empty string it will return -1)     
     */
    public class StringCalculatorTests
    {
        private StringCalculator objectUnderTest;

        //constructer is setup for tests
        //Arrange Act Assert = AAA
        //only one Test for one Aspect
        public StringCalculatorTests()
        {
            this.objectUnderTest = new StringCalculator();
        }
        // same as result.Should().Be(): Assert.Equal(0, result);

        [Theory]
        [InlineData("2,3", 5)]
        [InlineData("1", 1)]
        [InlineData("", -1)]
        [InlineData("100,200", 300)]

        public void WhenAddMulitpleNumbers(string numbers, int expectedresult)
        {
            var result = objectUnderTest.calculate(numbers, new Add());

            result.Should().Be(expectedresult);
        }

        [Theory]
        [InlineData("2,3", 6)]
        [InlineData("1", 1)]
        [InlineData("", -1)]
        [InlineData("100,200", 20000)]
        public void WhenMultiplyMulitpleNumbers(string numbers, int expectedresult)
        {
            var result = objectUnderTest.calculate(numbers, new Multiply());

            result.Should().Be(expectedresult);
        }
    }
}