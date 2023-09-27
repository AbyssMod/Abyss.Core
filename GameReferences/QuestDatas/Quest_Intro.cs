namespace Abyss.GameReferences.QuestDatas;
public static class Quest_Intro
{
    public static UnityEngine.Localization.LocalizedString titleKey = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Intro").titleKey;
    public static UnityEngine.Localization.LocalizedString summaryKey = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Intro").summaryKey;
    public static UnityEngine.Localization.LocalizedString[] resolutionKeys = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Intro").resolutionKeys;
    public static System.Collections.Generic.List<MapMarkerData> mapMarkersToRemoveOnCompletion = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Intro").mapMarkersToRemoveOnCompletion;
    public static bool showUnseenIndicators = true;
    public static System.Collections.Generic.List<QuestStepData> steps = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Intro").steps;
    public static System.Collections.Generic.List<QuestData> subquests = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Intro").subquests;
    public static QuestStepData onOfferedQuestStep = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Intro").onOfferedQuestStep;
    public static bool canBeOfferedAutomatically = false;
    public static System.Collections.Generic.List<QuestStepCondition> offerConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Intro").offerConditions;
    public static string PS5Subtask = "";
}
