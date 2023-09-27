namespace Abyss.GameReferences.QuestDatas;
public static class Quest_Fanatic
{
    public static UnityEngine.Localization.LocalizedString titleKey = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Fanatic").titleKey;
    public static UnityEngine.Localization.LocalizedString summaryKey = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Fanatic").summaryKey;
    public static UnityEngine.Localization.LocalizedString[] resolutionKeys = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Fanatic").resolutionKeys;
    public static System.Collections.Generic.List<MapMarkerData> mapMarkersToRemoveOnCompletion = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Fanatic").mapMarkersToRemoveOnCompletion;
    public static bool showUnseenIndicators = true;
    public static System.Collections.Generic.List<QuestStepData> steps = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Fanatic").steps;
    public static System.Collections.Generic.List<QuestData> subquests = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Fanatic").subquests;
    public static QuestStepData onOfferedQuestStep = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Fanatic").onOfferedQuestStep;
    public static bool canBeOfferedAutomatically = false;
    public static System.Collections.Generic.List<QuestStepCondition> offerConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Fanatic").offerConditions;
    public static string PS5Subtask = "";
}