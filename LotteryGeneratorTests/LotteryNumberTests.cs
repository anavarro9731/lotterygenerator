using System;
using LotteryNumberService;
using Xunit;

namespace LotteryNumberGeneratorTests
{
    public class LotteryNumberTests
    {
        public class WhenWeAskForASingleNumber
        {
            private const byte min = 1;
            private const byte max = 49;

            [Fact]
            private void TheNumberShouldBeBetweenOneAndFortyNine()
            {
                for (var i = 0; i < 100; i++)
                {
                    var number = LotteryNumber.Generate(new MonoStateRandomNumberGenerator(Int32.MaxValue));

                    Assert.InRange(number.Value, min, max);
                }
            }

            [Theory]
            [InlineData(1, "Red")]
            [InlineData(5, "Red")]
            [InlineData(9, "Red")]
            [InlineData(10, "Blue")]
            [InlineData(19, "Blue")]
            [InlineData(20, "Green")]
            [InlineData(29, "Green")]
            [InlineData(30, "Orange")]
            [InlineData(39, "Orange")]
            [InlineData(40, "Purple")]
            [InlineData(44, "Purple")]
            [InlineData(49, "Purple")]
            void TheColorShouldMatchOurAppendixValues(byte value, string colourName)
            {
                Assert.Equal(colourName, new LotteryNumber(value).Colour.Name);
            }
        }
    }
}