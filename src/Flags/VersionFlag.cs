using System.Reflection;

namespace lsep.Flags
{
    internal class VersionFlag
    {
        public static void PrintVersion()
        {
            var appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            Console.WriteLine($"v{appVersion.Major}.{appVersion.Minor}.{appVersion.Build}.{appVersion.Revision}");
        }
    }
}
