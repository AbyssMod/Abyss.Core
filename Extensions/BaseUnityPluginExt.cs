using System.IO;
using System.Reflection;
using BepInEx;

namespace Abyss.Extensions;

/// <summary>
/// Extensions for all BepInEx plugins
/// </summary>
public static class BaseUnityPluginExt
{
    public static Assembly GetAssembly(this BaseUnityPlugin mod) => mod.GetType().Assembly;

    public static string GetName(this BaseUnityPlugin mod) => mod.GetAssembly().GetName().Name;

    public static string FileName(this BaseUnityPlugin mod) => Path.GetFileName(mod.Info.Location);
}