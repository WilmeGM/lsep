namespace lsep
{
    internal class PathReader
    {
        public static string[] GetEnvironmentPathEntries() =>
            Environment.GetEnvironmentVariable("PATH")!.Split(Path.PathSeparator);
    }
}