using lsep.Flags;
using lsep.Utils;

namespace lsep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                foreach (var route in PathReader.GetEnvironmentPathEntries())
                    Console.WriteLine(route);

                return;
            }

            if (args.Length > 1) Console.WriteLine("are you trying to use multiples flags? That is not possible for now.");
            else if (args.Contains(ApplicationStrings.HELP) || args.Contains(ApplicationStrings.HELP_SHORTED)) HelpFlag.PrintHelpMessage();
            else if (args.Contains(ApplicationStrings.VERSION) || args.Contains(ApplicationStrings.VERSION_SHORTED)) VersionFlag.PrintVersion();
            else if (args.Contains(ApplicationStrings.UNIQUE) || args.Contains(ApplicationStrings.UNIQUE_SHORTED)) UniqueFlag.PrintUniqueEntries();
            else if (args.Contains(ApplicationStrings.NUMBERED) || args.Contains(ApplicationStrings.NUMBERED_SHORTED)) NumberedFlag.PrintNumberedEntries();
            else if (args.Contains(ApplicationStrings.COUNT) || args.Contains(ApplicationStrings.COUNT_SHORTED)) CountFlag.PrintEntriesCount();
            else if (args.Contains(ApplicationStrings.EXISTS) || args.Contains(ApplicationStrings.EXISTS_SHORTED)) ExistsFlag.PrintOnlyExistingEntries();
            else if (args.Contains(ApplicationStrings.MISSING) || args.Contains(ApplicationStrings.MISSING_SHORTED)) MissingFlag.PrintOnlyMissingEntries();
            else Console.WriteLine("option not found");
        }
    }
}