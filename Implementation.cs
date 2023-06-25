using MelonLoader;



namespace SmallFixToScenes
{
    internal class Implementation : MelonMod
    {
        [Obsolete]
        public override void OnApplicationStart()
        {
            Settings.OnLoad();/// ModSettings
            LoggerInstance.Msg($"Version {BuildInfo.Version}");
            //MelonLogger.Msg("TEST ==================== 01 " ); //====================

            
        }

        public override void OnSceneWasInitialized(int level, string name)
        {
            //MelonLogger.Msg("Debug Log ========================== Test1 = ");

            //Aaa();

            Patches.ChangeObjcets();
        }

        public static void Aaa()
        {
            MelonLogger.Msg("Debug Log ========================== Aaa = ");

        }



    }
}