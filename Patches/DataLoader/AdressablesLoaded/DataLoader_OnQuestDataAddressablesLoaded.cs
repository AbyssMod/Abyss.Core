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

[HarmonyPatch(typeof(DataLoader), nameof(DataLoader.OnQuestDataAddressablesLoaded))]
internal static class DataLoader_OnQuestDataAddressablesLoaded
{
    [HarmonyPostfix]
    private static void Postfix(DataLoader __instance, AsyncOperationHandle<IList<QuestData>> handle)
    {
        if(handle.Status != AsyncOperationStatus.Succeeded || !__instance._hasLoadedQuestData)
            return;
        try
        {
            AbyssEvents.OnQuestDataLoaded.Invoke(handle.Result);
            handle.Result.ForEach(questData =>
            {
                ClassGenerator.Export(questData);

                Exporter.Export(questData, Path.Combine(AbyssUtils.AbyssFolder, "Quests", $"{questData.name}.json"));
            });
        }
        catch (Exception e)
        {
            AbyssLogger.Error(e.ToString());
        }
    }
}