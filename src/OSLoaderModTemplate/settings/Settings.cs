using OSLoader;
using UnityEngine;

namespace OSLoaderModTemplate.Settings;

public class OSModLoaderTemplateSettings : ModSettings
{

    //There are other setting and attribute types
    //See also: https://ierdna100.github.io/OSLoader/docs/Mod/ModSettings.html

    [BoolSetting("A Very Cool Bool")]
    public bool MyCoolBool;
}
