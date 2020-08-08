using System.Reflection;

namespace BluBotCore
{
    public class Version
    {
        public static string Number { get { return Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion; } }
    }
}
