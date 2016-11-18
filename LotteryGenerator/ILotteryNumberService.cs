using System.Collections.Generic;

namespace LotteryNumberService
{
    public interface ILotteryNumberService
    {
        LotteryNumberSet GetLotteryNumberSet();
        IEnumerable<LotteryNumberSet> GetLotteryNumberSets(byte numberOfSets);
    }
}