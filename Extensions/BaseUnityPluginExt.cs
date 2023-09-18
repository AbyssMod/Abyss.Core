using System.IO;
using System.Reflection;
using BepInEx;

namespace Abyss.Extensions;

/// <summary>
/// Extensions for all BepInEx plugins
/// </summary>
public static class BaseUnityPluginExt
{
    /// <summary>
    /// Gets the assembly of this plugin
    /// </summary>
    public static Assembly GetAssembly(this BaseUnityPlugin mod) => mod.GetType().Assembly;

    /// <summary>
    /// Gets the name of this plugin based on it's assembly
    /// </summary>
    public static string GetName(this BaseUnityPlugin mod) => mod.GetAssembly().GetName().Name;

    /// <summary>
    /// Gets the file name of this plugin's assembly
    /// </summary>
    public static string FileName(this BaseUnityPlugin mod) => Path.GetFileName(mod.Info.Location);
}