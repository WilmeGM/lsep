using lsep.Utils;

namespace lsep.Flags
{
    internal class MissingFlag
    {
        public static void PrintOnlyMissingEntries()
        {
            var entries = PathReader.GetEnvironmentPathEntries();

            foreach (var entry in entries)
            {
                if (!Directory.Exists(entry))
                    Console.WriteLine(entry);
            }
        }
    }
}
