namespace Abyss.GameReferences.QuestDatas;
public static class Quest_Soldier
{
    public static UnityEngine.Localization.LocalizedString titleKey = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Soldier").titleKey;
    public static UnityEngine.Localization.LocalizedString summaryKey = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Soldier").summaryKey;
    public static UnityEngine.Localization.LocalizedString[] resolutionKeys = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Soldier").resolutionKeys;
    public static System.Collections.Generic.List<MapMarkerData> mapMarkersToRemoveOnCompletion = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Soldier").mapMarkersToRemoveOnCompletion;
    public static bool showUnseenIndicators = true;
    public static System.Collections.Generic.List<QuestStepData> steps = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Soldier").steps;
    public static System.Collections.Generic.List<QuestData> subquests = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Soldier").subquests;
    public static QuestStepData onOfferedQuestStep = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Soldier").onOfferedQuestStep;
    public static bool canBeOfferedAutomatically = false;
    public static System.Collections.Generic.List<QuestStepCondition> offerConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Soldier").offerConditions;
    public static string PS5Subtask = "";
}
