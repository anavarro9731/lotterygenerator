using System.Linq;

namespace LotteryNumberService
{
    internal class LotteryNumberSetWriter
    {
        public static void WriteSet(IWriteAFileToDisk filewriter, LotteryNumberSet numbers)
        {
            var contents = string.Join(", ", numbers.Select(n => n.Value).ToArray());
            filewriter.WriteToDisk(contents);
        }
    }
}