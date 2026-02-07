using lsep.Utils;

namespace lsep.Flags
{
    internal class NumberedFlag
    {
        public static void PrintNumberedEntries()
        {
            var entries = PathReader.GetEnvironmentPathEntries();

            int i = 1;
            foreach (var entry in entries)
            {
                Console.WriteLine($"{i}. {entry}");
                i++;
            }
        }
    }
}
