using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Abyss.Events;
using Abyss.Generators;
using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Abyss.Patches;


[HarmonyPatch]
internal static class AddressablesLoadedMethods
{
    [HarmonyTargetMethods]
    [UsedImplicitly]
    private static IEnumerable<MethodBase> TargetMethods()
    {
        foreach (var methodInfo in AccessTools.GetDeclaredMethods(typeof(DataLoader)).Where(method => method.Name.StartsWith("On") && method.Name.EndsWith("AddressablesLoaded"))) yield return methodInfo;
        yield return AccessTools.Method(typeof(AchievementManager), "OnAchievementDataAddressablesLoaded");
        yield return AccessTools.Method(typeof(ItemManager), "OnItemDataAddressablesLoaded");
        yield return AccessTools.Method(typeof(UpgradeManager), "OnUpgradeDataAddressablesLoaded");
    }

    [HarmonyPostfix]
    private static void Postfix(dynamic handle)
    {
        try
        {
            if(handle.Status != AsyncOperationStatus.Succeeded)
                return;

            foreach(var t in handle.Result)
            {
                ClassGenerator.Export(t);
            }

            var method = typeof(AbyssEvents).GetMethod("Invoke" + handle.Result.GetType().GenericTypeArguments[0].Name + "Loaded", AccessTools.all) as MethodInfo;
            if (method != null)
            {
                try
                {
                    method.Invoke(null, new object[] {handle.Result});
                }
                catch (Exception e)
                {
                    AbyssLogger.Error(e.ToString());
                }
            }
            else
            {
                AbyssLogger.Error("Could not find Invoke" + handle.Result.GetType().GenericTypeArguments[0].Name + "Loaded in AbyssEvents");
            }
        }
        catch (Exception e)
        {
            AbyssLogger.Error(e.ToString());
            throw;
        }
    }
}
