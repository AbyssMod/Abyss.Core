namespace Abyss.GameReferences.QuestDatas;
public static class Quest_Castaway
{
    public static UnityEngine.Localization.LocalizedString titleKey = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Castaway").titleKey;
    public static UnityEngine.Localization.LocalizedString summaryKey = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Castaway").summaryKey;
    public static UnityEngine.Localization.LocalizedString[] resolutionKeys = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Castaway").resolutionKeys;
    public static System.Collections.Generic.List<MapMarkerData> mapMarkersToRemoveOnCompletion = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Castaway").mapMarkersToRemoveOnCompletion;
    public static bool showUnseenIndicators = true;
    public static System.Collections.Generic.List<QuestStepData> steps = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Castaway").steps;
    public static System.Collections.Generic.List<QuestData> subquests = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Castaway").subquests;
    public static QuestStepData onOfferedQuestStep = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Castaway").onOfferedQuestStep;
    public static bool canBeOfferedAutomatically = false;
    public static System.Collections.Generic.List<QuestStepCondition> offerConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Castaway").offerConditions;
    public static string PS5Subtask = "";
}
