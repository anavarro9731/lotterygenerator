using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LotteryNumberService
{
    public class LotteryNumberSet : Collection<LotteryNumber>
    {
        public LotteryNumberSet(IEnumerable<LotteryNumber> numbers)
        {
            numbers.ToList().ForEach(Add);
        }

        public static LotteryNumberSet Generate(Func<LotteryNumber> getLotteryNumber, int capacity = 6)
        {
            var set = new List<LotteryNumber>(capacity);

            while (set.Count < set.Capacity)
            {
                var next = getLotteryNumber();
                if (!set.Exists(n => n.Value == next.Value))
                set.Add(next);
            }
                

            return new LotteryNumberSet(set);
        }
    }
}