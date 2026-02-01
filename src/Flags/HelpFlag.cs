namespace lsep.Flags
{
    internal class HelpFlag
    {
        public static void PrintHelpMessage()
        {
            Console.WriteLine("""
                    lsep — List Environment PATH

                    Usage:
                      lsep [options]

                    Description:
                      lsep is a small command-line utility that inspects the PATH environment
                      variable and prints each entry on a separate line. Additionally, lsep pretend
                      having various options to format, modify, count, check, and more, your entries
                      from PATH variable.

                    Flags:
                      --version, -v     Show current lsep version
                      --help, -h        Show this help message
                      --unique, -u      Show only distinct entries
                      --numbered, -n    Show entries numbered  
                      --count, -c       Show entries count
                      --exists, -e      Show only entries that really exist on disk
                      more options soon...

                    Examples:
                      lsep
                          List all PATH entries
                      lsep --help (or -h)
                      lsep --version (or -v)
                      lsep --unique (or -u)
                      lsep --numbered (or -n)
                      lsep --count (or -c)
                      lsep --exists (or -e)
                    """);
        }
    }
}
