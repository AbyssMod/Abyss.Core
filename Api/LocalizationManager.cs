using System.Collections.Generic;
using UnityEngine.Localization;

namespace Abyss.Api;

internal static class LocalizationManager
{
    internal static void AddModLocalization(LocalizedModContent localizedModContent)
    {
        localizedModContent.RegisterText(LocalizationDatabase);
    }

    public static readonly Dictionary<string, string> LocalizationDatabase = new();

    public static LocalizedString CreateLocalizedString(string key, string value)
    {
        LocalizationDatabase[key] = value;
        return new LocalizedString("Items" /*todo: figure out best thing to put here*/, key);
    }
}