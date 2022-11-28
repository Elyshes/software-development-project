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
        [InlineData("2,3,80,980", 1065)]
        [InlineData("6*9", 54)]
        [InlineData("4*3*0", 0)]
        public void WhenAddMulitpleNumbers(string numbers, int expectedresult)
        {
            var result = objectUnderTest.Add(numbers);

            result.Should().Be(expectedresult);
        }

    }
}