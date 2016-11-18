namespace LotteryNumberService
{
    public interface IGenerateRandomNumbers
    {
        byte GetNumber(byte lower, byte upper);
    }
}