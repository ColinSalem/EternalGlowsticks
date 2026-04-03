using BepInEx.Logging;

namespace EternalGlowsticks
{
    internal static class Logger
    {
        private static ManualLogSource m_LogSource;

        static Logger()
        {
            m_LogSource = new ManualLogSource("EternalGlowsticks");
            BepInEx.Logging.Logger.Sources.Add(m_LogSource);
        }

        private static string Format(object msg) => msg.ToString() ?? "";
        public static void Debug(object msg) => Logger.m_LogSource.LogDebug((object)Logger.Format(msg));
        public static void Info(object msg) => Logger.m_LogSource.LogInfo((object)Logger.Format(msg));
        public static void Warn(object msg) => Logger.m_LogSource.LogWarning((object)Logger.Format(msg));
        public static void Error(object msg) => Logger.m_LogSource.LogError((object)Logger.Format(msg));
        public static void Fatal(object msg) => Logger.m_LogSource.LogFatal((object)Logger.Format(msg));
    }
}
