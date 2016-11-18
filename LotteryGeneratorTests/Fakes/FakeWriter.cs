using LotteryNumberService;

namespace LotteryNumberGeneratorTests.Fakes
{
    internal class FakeWriter : IWriteAFileToDisk
    {
        public bool Written { get; private set; }

        public void WriteToDisk(string contents)
        {
            Written = true;
        }
    }
}