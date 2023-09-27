using System;
using System.Collections.Generic;
using System.IO;
using Abyss.Events;
using Abyss.Generators;
using Abyss.Utilities;
using FluffyUnderware.DevTools.Extensions;
using HarmonyLib;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Abyss.Patches;

[HarmonyPatch(typeof(DataLoader), nameof(DataLoader.OnWorldEventDataAddressablesLoaded))]
internal static class DataLoader_OnWorldEventDataAddressablesLoaded
{
    [HarmonyPostfix]
    private static void Postfix(DataLoader __instance, AsyncOperationHandle<IList<WorldEventData>> handle)
    {
        if(handle.Status != AsyncOperationStatus.Succeeded || !__instance._hasLoadedWorldEventData)
            return;
        try
        {
            AbyssEvents.OnWorldEventDataLoaded.Invoke(handle.Result);
            handle.Result.ForEach(worldEvent =>
            {
                ClassGenerator.Export(worldEvent);
                Exporter.Export(worldEvent, Path.Combine(AbyssUtils.AbyssFolder, "WorldEvents", $"{worldEvent.name}.json"));
            });
        }
        catch (Exception e)
        {
            AbyssLogger.Error(e.ToString());
        }
    }
}