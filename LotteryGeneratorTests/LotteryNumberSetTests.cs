using System;
using LotteryNumberGeneratorTests.Fakes;
using LotteryNumberService;
using Xunit;

namespace LotteryNumberGeneratorTests
{
    public class LotteryNumberSetTests
    {
        public class WhenWeGenerateANewSet
        {
            [Fact]
            private void DuplicateNumbersShouldNeverBeAllowed()
            {
                var set = LotteryNumberSet.Generate(() => LotteryNumber.Generate(new FakeRandomNumberGenerator()));

                Assert.Equal(6, set.Count);
            }

            [Fact]
            private void TheSetShouldHaveSixNumbers()
            {
                var set = LotteryNumberSet.Generate(() => LotteryNumber.Generate(new MonoStateRandomNumberGenerator(Int32.MaxValue)));

                Assert.Equal(6, set.Count);
            }
        }
    }
}