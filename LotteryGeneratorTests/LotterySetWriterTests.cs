using System;
using LotteryNumberGeneratorTests.Fakes;
using LotteryNumberService;
using Xunit;

namespace LotteryNumberGeneratorTests
{
    public class LotterySetWriterTests
    {
        public class WhenGivenALotteryNumberSetToPersist
        {
            [Fact]
            private void ItShouldWriteItToDisk()
            {
                var writer = new FakeWriter();

                LotteryNumberSetWriter.WriteSet(writer,
                    LotteryNumberSet.Generate(() => LotteryNumber.Generate(new MonoStateRandomNumberGenerator(Int32.MaxValue))));

                Assert.True(writer.Written);
            }
        }
    }
}