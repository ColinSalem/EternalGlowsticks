using HarmonyLib;

namespace EternalGlowsticks;

[HarmonyPatch]
internal static class Patch {
    [HarmonyPatch(typeof(GlowstickInstance), nameof(GlowstickInstance.Setup))]
    [HarmonyPostfix]
    static void GlowstickSetup_Postfix(GlowstickInstance __instance) {
        __instance.s_lightLifeTime = float.PositiveInfinity;
        Logger.Info("Patched s_lightLifeTime=Infinity");
    }
}