namespace Abyss.GameReferences.QuestDatas;
public static class Quest_Hermitage
{
    public static UnityEngine.Localization.LocalizedString titleKey = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Hermitage").titleKey;
    public static UnityEngine.Localization.LocalizedString summaryKey = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Hermitage").summaryKey;
    public static UnityEngine.Localization.LocalizedString[] resolutionKeys = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Hermitage").resolutionKeys;
    public static System.Collections.Generic.List<MapMarkerData> mapMarkersToRemoveOnCompletion = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Hermitage").mapMarkersToRemoveOnCompletion;
    public static bool showUnseenIndicators = true;
    public static System.Collections.Generic.List<QuestStepData> steps = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Hermitage").steps;
    public static System.Collections.Generic.List<QuestData> subquests = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Hermitage").subquests;
    public static QuestStepData onOfferedQuestStep = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Hermitage").onOfferedQuestStep;
    public static bool canBeOfferedAutomatically = false;
    public static System.Collections.Generic.List<QuestStepCondition> offerConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Hermitage").offerConditions;
    public static string PS5Subtask = "";
}
