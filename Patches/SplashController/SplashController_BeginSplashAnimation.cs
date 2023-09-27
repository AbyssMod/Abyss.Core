using System.Threading.Tasks;
using HarmonyLib;

namespace Abyss.Patches;

[HarmonyPatch(typeof(SplashController), nameof(SplashController.BeginSplashAnimation))]
internal static class SplashController_BeginSplashAnimation
{
    [HarmonyPrefix]
    private static bool Prefix(SplashController __instance, ref Task __result)
    {
        __instance.OnSplashComplete();
        __result = Task.CompletedTask;
        return false;
    }
}