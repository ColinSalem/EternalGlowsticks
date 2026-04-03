using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace EternalGlowsticks;

[BepInPlugin("ColinSalem.EternalGlowsticks", "EternalGlowsticks", "1.0.0")]
public class Plugin : BasePlugin
{
    public override void Load()
    {
        new Harmony("ColinSalem.EternalGlowsticks").PatchAll();
        Log.LogMessage("loaded EternalGlowsticks");
    }
}