using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Localization.Events;
using UnityEngine.SceneManagement;

namespace Abyss.Events;

/// <summary>
/// Contains events that are invoked by the Abyss API
/// </summary>
public static class AbyssEvents
{
    /// <summary>
    /// Invoked when the game managers are loaded, equivalent to a Harmony Postfix on <see cref="GameManager.WaitForAllAsyncManagers"/>
    /// </summary>
    public static readonly UnityEvent OnGameManagersLoaded = new();

    /// <summary>
    /// Invoked when a scene is loaded, equivalent to adding a listener to <see cref="SceneManager.sceneLoaded"/>
    /// </summary>
    public static readonly UnityEventScene OnSceneLoaded = new();

    /// <summary>
    /// Invoked when the world event data is loaded, equivalent to a Harmony Postfix on <see cref="DataLoader.OnWorldEventDataAddressablesLoaded"/>
    /// </summary>
    public static readonly UnityEventAdressableLoaded<IList<WorldEventData>> OnWorldEventDataLoaded = new();

    /// <summary>
    /// Invoked when the quest data is loaded, equivalent to a Harmony Postfix on <see cref="DataLoader.OnQuestDataAddressablesLoaded"/>
    /// </summary>
    public static readonly UnityEventAdressableLoaded<IList<QuestData>> OnQuestDataLoaded = new();



}