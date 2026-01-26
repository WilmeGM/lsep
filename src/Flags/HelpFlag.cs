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

                    Options:
                      --version, -v   Show current lsep version
                      --help, -h      Show this help message
                      more options soon...

                    Examples:
                      lsep
                          List all PATH entries

                      lsep --help (or -h)
                          Show this help message

                      lsep --version
                          Show this help message
                    """);
        }
    }
}
