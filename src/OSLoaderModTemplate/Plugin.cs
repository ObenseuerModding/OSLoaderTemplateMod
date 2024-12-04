using OSLoader;
using UnityEngine;
using OSLoaderModTemplate.Settings;

namespace OSLoaderModTemplate;

public class OSModTemplatePlugin : Mod
{
    public static OSModTemplatePlugin Instance;

    public override void InitializeMod()
    {
        //This is where you do basic init but no patching
        //Or any of the heavy lifting

        Instance = this;
        settings = new OSModLoaderTemplateSettings();
    }

    public override void OnModInitialized()
    {
        //At this point the mod is loaded
        //The hierarchy and patching should be available here
        Debug.Log($"{Instance.info.name} version {Instance.info.version} is loaded");
    }

    public override bool UnloadMod()
    {
        //Not implemented yet
        return false;
    }
}
