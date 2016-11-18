using System.Linq;
using System.Collections.Generic;
using LotteryNumberService;
using Xunit;

namespace LotteryNumberGeneratorTests
{
    public class LotteryNumberServiceTests
    {
        public class WhenWeRequestASetOfLotteryNumbers
        {
            [Fact]
            private void ItShouldReturnASetOfLotteryNumbers()
            {
                var set = new LotteryNumberService.LotteryNumberService().GetLotteryNumberSet();

                Assert.IsType<LotteryNumberSet>(set);
            }
        }

        public class WhenWeRequestACollectionOfSetsOfLotteryNumbers
        {
            [Fact]
            private void ItShouldReturnACollectionOfSetsOfLotteryNumbers()
            {
                var set = new LotteryNumberService.LotteryNumberService().GetLotteryNumberSets(5);

                Assert.IsAssignableFrom<IEnumerable<LotteryNumberSet>>(set);
            }

            [Fact]
            private void TheNumberOfSetsInTheCollectionReturnedShouldEqualTheNumberWeRequested()
            {
                const byte requestedNumber = 50;

                var set = new LotteryNumberService.LotteryNumberService().GetLotteryNumberSets(requestedNumber);

                Assert.True(set.Count() == requestedNumber);
            }
        }
    }
}