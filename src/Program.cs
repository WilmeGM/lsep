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
            else if (args.Contains("--help") || args.Contains("-h")) HelpFlag.PrintHelpMessage();
            else if (args.Contains("--version") || args.Contains("-v")) VersionFlag.PrintVersion();
            else if (args.Contains("--unique") || args.Contains("-u")) UniqueFlag.PrintUniqueEntries();
            else if (args.Contains("--numbered") || args.Contains("-n")) NumberedFlag.PrintNumberedEntries();
            else Console.WriteLine("option not found");
        }
    }
}