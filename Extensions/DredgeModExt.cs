using System.IO;

namespace Abyss.Extensions;

/// <summary>
/// Extensions for DredgeMods
/// </summary>
public static class DredgeModExt
{
    /// <summary>
    /// Get the name of this mod from it's dll name
    /// </summary>
    public static string GetName(this DredgeMod? dredgeMod)
    {
        if(dredgeMod == null)
            return "null";
        return dredgeMod.GetAssembly()?.GetName().Name ?? dredgeMod.Info.Metadata.Name;
    }
}