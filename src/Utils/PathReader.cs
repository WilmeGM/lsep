namespace lsep.Utils
{
    internal class PathReader
    {
        public static string[] GetEnvironmentPathEntries() =>
            Environment.GetEnvironmentVariable("PATH")!.Split(Path.PathSeparator);
    }
}