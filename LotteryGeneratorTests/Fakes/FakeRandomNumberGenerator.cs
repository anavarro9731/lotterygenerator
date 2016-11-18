using System.Collections.Generic;
using LotteryNumberService;

namespace LotteryNumberGeneratorTests.Fakes
{
    internal class FakeRandomNumberGenerator : IGenerateRandomNumbers
    {
        private static readonly Queue<byte> Numbers = new Queue<byte>(new byte[]
        {
            1, 1, 2, 3, 4, 4, 5, 6, 7, 7, 8, 9
        });

        public byte GetNumber(byte lower, byte upper)
        {
            return Numbers.Dequeue();
        }
    }
}