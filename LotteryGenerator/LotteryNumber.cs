using System;
using System.Drawing;
using System.Linq;

namespace LotteryNumberService
{
    public class LotteryNumber
    {
        public LotteryNumber(byte value)
        {
            Value = value;
            Colour = ComputeColour(value);
        }

        public byte Value { get; }
        public Color Colour { get; }

        public static LotteryNumber Generate(IGenerateRandomNumbers randomGenerator)
        {            
            return new LotteryNumber(randomGenerator.GetNumber(1, 49));
        }

        private Color ComputeColour(byte value)
        {
            if (Enumerable.Range(1, 9).Contains(value))
                return Color.Red;
            if (Enumerable.Range(10, 10).Contains(value))
                return Color.Blue;
            if (Enumerable.Range(20, 10).Contains(value))
                return Color.Green;
            if (Enumerable.Range(30, 10).Contains(value))
                return Color.Orange;
            if (Enumerable.Range(40, 10).Contains(value))
                return Color.Purple;

            throw new ArgumentOutOfRangeException();
        }
    }
}