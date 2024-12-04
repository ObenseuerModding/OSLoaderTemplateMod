using OSLoader;
using UnityEngine;
using OSLoaderModTemplate.Settings;

namespace OSLoaderModTemplate;

public class TestMod : Mod
{
    public static TestMod instance;

    public override void InitializeMod()
    {
        instance = this;
        settings = new CustomSettingsExample();
    }

    public override void OnModInitialized()
    {
        Debug.Log("This amazing mod was loaded!");
    }

    public override bool UnloadMod()
    {
        return false;
    }
}
