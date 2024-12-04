using OSLoader;
using UnityEngine;
using OSLoaderModTemplate.Settings;

namespace OSLoaderModTemplate;

public class OSModTemplatePlugin : Mod
{
    internal static OSModTemplatePlugin? Instance;
    internal static OSLoader.Logger? PluginLog;

    public override void InitializeMod()
    {
        //This is where you do basic init but no patching
        //Or any of the heavy lifting

        Instance = this;
        settings = new OSModLoaderTemplateSettings();
        PluginLog = new(info.name, true);
        PluginLog?.Log($"{info.name} is initializing");
    }

    public override void OnModInitialized()
    {
        //At this point the mod is loaded
        //The hierarchy and patching should be available here
        PluginLog?.Log($"{info.name} version {info.version} is loading");
    }

    public override bool UnloadMod()
    {
        //Not implemented yet
        return false;
    }
}
