using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Abyss;

public static class ScriptableObjectInstances
{
    private static IReadOnlyList<WorldEventData>? _worldEventDatas;

    /// <summary>
    /// All world event datas.
    /// </summary>
    public static IReadOnlyCollection<WorldEventData> WorldEventDatas => _worldEventDatas ??= Addressables.LoadAssetsAsync<WorldEventData>(GameManager.Instance.DataLoader.worldEventDataAssetLabelReference, null).WaitForCompletion().ToList().AsReadOnly();

    private static IReadOnlyList<WeatherData>? _weatherDatas;

    /// <summary>
    /// All weather datas.
    /// </summary>
    public static IReadOnlyCollection<WeatherData> WeatherDatas => _weatherDatas ??= Addressables.LoadAssetsAsync<WeatherData>(GameManager.Instance.DataLoader.weatherDataAssetLabelReference, null).WaitForCompletion().ToList().AsReadOnly();

    private static IReadOnlyList<QuestData>? _questDatas;

    /// <summary>
    /// All quest datas.
    /// </summary>
    public static IReadOnlyCollection<QuestData> QuestDatas => _questDatas ??= Addressables.LoadAssetsAsync<QuestData>(GameManager.Instance.DataLoader.questDataAssetLabelReference, null).WaitForCompletion().ToList().AsReadOnly();

    private static IReadOnlyList<GridConfiguration>? _gridConfigurations;

    /// <summary>
    /// All grid configurations.
    /// </summary>
    public static IReadOnlyCollection<GridConfiguration> GridConfigurations => _gridConfigurations ??= Addressables.LoadAssetsAsync<GridConfiguration>(GameManager.Instance.DataLoader.gridConfigDataAssetLabelReference, null).WaitForCompletion().ToList().AsReadOnly();

    private static IReadOnlyList<MapMarkerData>? _mapMarkerDatas;

    /// <summary>
    /// All map marker datas.
    /// </summary>
    public static IReadOnlyCollection<MapMarkerData> MapMarkerDatas => _mapMarkerDatas ??= Addressables.LoadAssetsAsync<MapMarkerData>(GameManager.Instance.DataLoader.mapMarkerDataAssetLabelReference, null).WaitForCompletion().ToList().AsReadOnly();

    private static IReadOnlyList<QuestGridConfig>? _questGridConfigs;

    /// <summary>
    /// All quest grid configs.
    /// </summary>
    public static IReadOnlyCollection<QuestGridConfig> QuestGridConfigs => _questGridConfigs ??= Addressables.LoadAssetsAsync<QuestGridConfig>(GameManager.Instance.DataLoader.questGridDataAssetLabelReference, null).WaitForCompletion().ToList().AsReadOnly();

    private static IReadOnlyList<QuestStepData>? _questStepDatas;

    /// <summary>
    /// All quest step datas.
    /// </summary>
    public static IReadOnlyCollection<QuestStepData> QuestStepDatas => _questStepDatas ??= QuestDatas.SelectMany(questData => questData.steps).ToList().AsReadOnly();

}