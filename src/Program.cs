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

            if (args.Contains("--help") || args.Contains("-h")) HelpFlag.PrintHelpMessage();
            else if (args.Contains("--version") || args.Contains("-v")) VersionFlag.PrintVersion();
            else Console.WriteLine("options not found");
        }
    }
}