using lsep.Utils;

namespace lsep.Flags
{
    internal class ExistsFlag
    {
        public static void PrintOnlyExistingEntries()
        {
            var entries = PathReader.GetEnvironmentPathEntries();

            foreach (var entry in entries)
            {
                if (Directory.Exists(entry))
                    Console.WriteLine(entry);
            }
        }
    }
}