using UnityEngine.Events;
using UnityEngine.Localization.Events;

namespace Abyss.Events;

/// <summary>
/// Contains events that are invoked by the Abyss API
/// </summary>
public static class AbyssEvents
{
    public static readonly UnityEvent OnGameManagersLoaded = new();

    public static readonly UnityEventScene OnSceneLoaded = new();

}