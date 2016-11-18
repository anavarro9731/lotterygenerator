using System;
using LotteryNumberService;
using Xunit;

namespace LotteryNumberGeneratorTests
{
    public class MonoStateRandomNumberGeneratorTests
    {
        public class WhenWeAskForANumber
        {
            /// <summary>
            /// Assume over a large enough dataset the average value should be near the median of the bounds
            /// </summary>
            [Fact]
            private void TheNumberShouldBeRandom()
            {
                var total = 0;
                const int iterations = 10000;
                const byte min = 0;
                const byte max = 100;

                var random = new MonoStateRandomNumberGenerator(Int32.MaxValue);

                for (var i = 0; i < iterations; i++)
                {
                    var number = random.GetNumber(min, max);
                    total += number;
                }

                Assert.InRange(total/iterations, max/2 - 1, max/2 + 1);
            }
        }
    }
}