namespace Abyss.GameReferences.QuestDatas;
public static class Quest_Dog
{
    public static QuestData Quest_DogInstance = (QuestData)System.Linq.Enumerable.First(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_Dog");
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString titleKey = Quest_DogInstance.titleKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString summaryKey = Quest_DogInstance.summaryKey;
     ///<json>
     /// {
     ///    "$content": [
     ///        [],
     ///        [],
     ///        []
     ///    ],
     ///    "$type": "UnityEngine.Localization.LocalizedString[]"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString[] resolutionKeys = Quest_DogInstance.resolutionKeys;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[MapMarkerData, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<MapMarkerData> mapMarkersToRemoveOnCompletion = Quest_DogInstance.mapMarkersToRemoveOnCompletion;
    public static bool showUnseenIndicators = true;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "mapMarkersToAddOnStart": [],
     ///            "mapMarkersToDeleteOnCompletion": [],
     ///            "hiddenWhenActive": false,
     ///            "hiddenWhenComplete": false,
     ///            "shortActiveKey": [],
     ///            "longActiveKey": [],
     ///            "completedKey": [],
     ///            "hideIfThisStepIsComplete": null,
     ///            "showAtDock": false,
     ///            "stepDock": null,
     ///            "showAtSpeaker": false,
     ///            "stepSpeaker": null,
     ///            "yarnRootNode": "",
     ///            "showConditions": [],
     ///            "canBeFailed": false,
     ///            "failureEvents": [],
     ///            "allowAutomaticCompletion": false,
     ///            "conditionMode": "ALL",
     ///            "completeConditions": []
     ///        },
     ///        {
     ///            "mapMarkersToAddOnStart": [],
     ///            "mapMarkersToDeleteOnCompletion": [],
     ///            "hiddenWhenActive": false,
     ///            "hiddenWhenComplete": false,
     ///            "shortActiveKey": [],
     ///            "longActiveKey": [],
     ///            "completedKey": [],
     ///            "hideIfThisStepIsComplete": null,
     ///            "showAtDock": false,
     ///            "stepDock": null,
     ///            "showAtSpeaker": false,
     ///            "stepSpeaker": null,
     ///            "yarnRootNode": "",
     ///            "showConditions": [],
     ///            "canBeFailed": true,
     ///            "failureEvents": [
     ///                {
     ///                    "itemId": "quest-dog",
     ///                    "resolutionIndex": 2,
     ///                    "$type": "DestroyItemEvent"
     ///                }
     ///            ],
     ///            "allowAutomaticCompletion": false,
     ///            "conditionMode": "ALL",
     ///            "completeConditions": []
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[QuestStepData, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<QuestStepData> steps = Quest_DogInstance.steps;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[QuestData, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<QuestData> subquests = Quest_DogInstance.subquests;
     ///<json>
     /// null
     /// </json>
    public static QuestStepData onOfferedQuestStep = null;
    public static bool canBeOfferedAutomatically = false;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[QuestStepCondition, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<QuestStepCondition> offerConditions = Quest_DogInstance.offerConditions;
    public static string PS5Subtask = "";
}
