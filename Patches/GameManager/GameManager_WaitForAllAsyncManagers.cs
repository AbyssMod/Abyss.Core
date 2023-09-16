using Abyss.Events;
using HarmonyLib;

namespace Abyss.Patches;

[HarmonyPatch(typeof(GameManager), nameof(GameManager.WaitForAllAsyncManagers))]
internal static class GameManager_WaitForAllAsyncManagers
{
    [HarmonyPostfix]
    private static void Postfix()
    {
        AbyssEvents.OnGameManagersLoaded.Invoke();
    }
}