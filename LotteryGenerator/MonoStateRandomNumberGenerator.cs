using System;

namespace LotteryNumberService
{
    internal class MonoStateRandomNumberGenerator : IGenerateRandomNumbers
    {
        private static Random _random;

        public MonoStateRandomNumberGenerator(int? seed = null)
        {
            _random = _random ?? new Random(seed ?? DateTime.UtcNow.Millisecond);
        }

        public byte GetNumber(byte lower, byte upper)
        {
            return (byte) _random.Next(lower, upper);
        }
    }
}