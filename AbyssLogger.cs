using static Abyss.Utilities.AbyssUtils;

namespace Abyss;

/// <summary>
/// Allows for easy logging from anywhere in the mod, using the mod's plugin type
/// </summary>
public static class AbyssLogger
{
    /// <inheritdoc cref="Info{T}"/>
    public static void Log<T>(object? obj) where T : DredgeMod => Info<T>(obj);

    /// <summary>
    /// Logs an info message from the specified Mod's Logger
    /// </summary>
    public static void Info<T>(object? obj) where T : DredgeMod
    {
        GetMod<T>().Logger.LogInfo(obj ?? "null");
    }

    /// <summary>
    /// Logs an error message from the specified Mod's Logger
    /// </summary>
    public static void Error<T>(object? obj) where T : DredgeMod
    {
        GetMod<T>().Logger.LogError(obj ?? "null");
    }

    /// <summary>
    /// Logs a warning message from the specified Mod's Logger
    /// </summary>
    public static void Warning<T>(object? obj) where T : DredgeMod
    {
        GetMod<T>().Logger.LogWarning(obj ?? "null");
    }

    internal static void Log(object? obj) => Info(obj);


    internal static void Info(object? obj)
    {
        lock (Main.Logger)
        {
            Main.Logger.LogInfo(obj ?? "null");
        }
    }

    internal static void Error(object? obj)
    {
        lock (Main.Logger)
        {
            Main.Logger.LogError(obj ?? "null");
        }
    }

    internal static void Warning(object? obj)
    {
        lock (Main.Logger)
        {
            Main.Logger.LogWarning(obj ?? "null");
        }
    }
}