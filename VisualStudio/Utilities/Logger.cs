namespace SmallFixToScenes
{
    public class Logger
    {
        public static void Log(string message, params object[] parameters)              => Melon<SmallFixToScenes>.Logger.Msg($"{message}", parameters);
        public static void LogWarning(string message, params object[] parameters)       => Melon<SmallFixToScenes>.Logger.Warning($"{message}", parameters);
        public static void LogError(string message, params object[] parameters)         => Melon<SmallFixToScenes>.Logger.Error($"{message}", parameters);
        public static void LogSeperator(params object[] parameters)                     => Melon<SmallFixToScenes>.Logger.Msg("==============================================================================", parameters);
        public static void LogStarter()                                                 => Melon<SmallFixToScenes>.Logger.Msg($"Mod loaded with v{BuildInfo.Version}");
    }
}