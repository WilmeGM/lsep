using lsep.Utils;

namespace lsep.Flags
{
    internal class CountFlag
    {
        public static void PrintEntriesCount()
        {
            Console.WriteLine(PathReader.GetEnvironmentPathEntries().Length);
        }
    }
}