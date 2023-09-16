using HarmonyLib;
using UnityEngine;

namespace Abyss.Patches;

//todo: make these settings (once settings are done)

[HarmonyPatch(typeof(Debug), nameof(Debug.Log), typeof(object))]
internal static class UnityLogging
{
    [HarmonyPostfix]
    private static void Postfix(object message)
    {
        //AbyssMain.UnityLog.LogInfo(message);
    }
}

[HarmonyPatch(typeof(Debug), nameof(Debug.LogWarning), typeof(object))]
internal static class Debug_LogWarning
{
    [HarmonyPostfix]
    private static void Postfix(object message)
    {
        AbyssMain.UnityLog.LogWarning(message);
    }
}

[HarmonyPatch(typeof(Debug), nameof(Debug.LogError), typeof(object))]
internal static class Debug_LogError
{
    [HarmonyPostfix]
    private static void Postfix(object message)
    {
        AbyssMain.UnityLog.LogError(message);
    }
}
