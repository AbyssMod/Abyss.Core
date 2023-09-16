using Abyss.Api;
using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine.Localization.Settings;

namespace Abyss.Patches;

[HarmonyPatch(typeof(LocalizedStringDatabase),"ProcessUntranslatedText")]
internal static class LocalizedStringDatabase_ProcessUntranslatedText
{
    [HarmonyPrefix]
    // ReSharper disable once RedundantAssignment
    // ReSharper disable once InconsistentNaming
    private static bool Prefix(ref string __result, string key) => !LocalizationManager.LocalizationDatabase.TryGetValue(key, out __result);
}