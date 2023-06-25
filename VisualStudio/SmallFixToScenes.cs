namespace SmallFixToScenes
{
    internal class SmallFixToScenes : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
#if DEBUG
            Logger.LogStarter();
#endif
        }

        // does this need to be OnSceneWasInitialized?
        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            Patches.ChangeObjcets();
            base.OnSceneWasInitialized(buildIndex, sceneName);
        }

        //public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        //{
        //    Patches.ChangeObjcets();
        //    base.OnSceneWasLoaded(buildIndex, sceneName);
        //}
    }
}