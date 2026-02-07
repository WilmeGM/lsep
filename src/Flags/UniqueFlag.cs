using lsep.Utils;

namespace lsep.Flags
{
    internal class UniqueFlag
    {
        public static void PrintUniqueEntries()
        {
            var entries = PathReader.GetEnvironmentPathEntries();
            foreach (var entry in entries.Distinct())
            {
                Console.WriteLine(entry);
            }
        }
    }
}
