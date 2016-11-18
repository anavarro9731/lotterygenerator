using System.Collections.Generic;
using System.Linq;

namespace LotteryNumberService
{
    public class LotteryNumberService : ILotteryNumberService
    {
        public LotteryNumberSet GetLotteryNumberSet()
        {
            return LotteryNumberSet.Generate(() => LotteryNumber.Generate(new MonoStateRandomNumberGenerator()));
        }

        public IEnumerable<LotteryNumberSet> GetLotteryNumberSets(byte numberOfSets)
        {
            return Enumerable.Range(1, numberOfSets).Select(n => GetLotteryNumberSet());
        }
    }
}