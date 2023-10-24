namespace Abyss.GameReferences.GridConfigurations;
public static class LighthouseRuinDoor
{
    public static GridConfiguration LighthouseRuinDoorInstance = (GridConfiguration)System.Linq.Enumerable.First(ScriptableObjectInstances.GridConfigurations, x => x.name == "LighthouseRuinDoor");
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[CellGroupConfiguration, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CellGroupConfiguration> cellGroupConfigs = LighthouseRuinDoorInstance.cellGroupConfigs;
    public static ItemType mainItemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype mainItemSubtype = ItemSubtype.NONE | ItemSubtype.GENERAL;
     ///<json>
     /// {
     ///    "harvestMinigameType": "DREDGE_RADIAL",
     ///    "perSpotMin": 1,
     ///    "perSpotMax": 1,
     ///    "harvestItemWeight": 1.0,
     ///    "regenHarvestSpotOnDestroy": false,
     ///    "harvestPOICategory": "NONE",
     ///    "harvestableType": "DREDGE",
     ///    "harvestDifficulty": "HARD",
     ///    "canBeReplacedWithResearchItem": false,
     ///    "canBeCaughtByRod": false,
     ///    "canBeCaughtByPot": false,
     ///    "canBeCaughtByNet": false,
     ///    "affectedByFishingSustain": true,
     ///    "hasMinDepth": false,
     ///    "minDepth": "VERY_SHALLOW",
     ///    "hasMaxDepth": false,
     ///    "maxDepth": "VERY_SHALLOW",
     ///    "zonesFoundIn": "",
     ///    "canBeSoldByPlayer": false,
     ///    "canBeSoldInBulkAction": false,
     ///    "value": 0.0,
     ///    "hasSellOverride": false,
     ///    "sellOverrideValue": 0.0,
     ///    "sprite": {
     ///
     ///    },
     ///    "platformSpecificSpriteOverrides": null,
     ///    "itemColor": {
     ///        "r": 0.227451,
     ///        "g": 0.1568628,
     ///        "b": 0.1254902,
     ///        "a": 1.0
     ///    },
     ///    "canBeDiscardedByPlayer": false,
     ///    "showAlertOnDiscardHold": false,
     ///    "discardHoldTimeOverride": false,
     ///    "discardHoldTimeSec": 0.0,
     ///    "canBeDiscardedDuringQuestPickup": false,
     ///    "damageMode": "NONE",
     ///    "moveMode": "FREE",
     ///    "ignoreDamageWhenPlacing": false,
     ///    "isUnderlayItem": false,
     ///    "forbidStorageTray": true,
     ///    "dimensions": [
     ///        {
     ///
     ///        },
     ///        {
     ///
     ///        },
     ///        {
     ///
     ///        },
     ///        {
     ///
     ///        }
     ///    ],
     ///    "squishFactor": 0.0,
     ///    "itemOwnPrerequisites": [],
     ///    "researchPrerequisites": [],
     ///    "researchPointsRequired": 0,
     ///    "buyableWithoutResearch": false,
     ///    "id": "quest-tablet-4",
     ///    "itemNameKey": [],
     ///    "itemDescriptionKey": [],
     ///    "itemInsaneTitleKey": [],
     ///    "itemInsaneDescriptionKey": [],
     ///    "linkedDialogueNode": "",
     ///    "dialogueNodeSpecificDescription": [],
     ///    "itemType": "GENERAL,ALL",
     ///    "itemSubtype": "GENERAL,ALL",
     ///    "tooltipTextColor": {
     ///        "r": 0.4901961,
     ///        "g": 0.3843137,
     ///        "b": 0.2666667,
     ///        "a": 1.0
     ///    },
     ///    "tooltipNotesColor": {
     ///        "r": 1.0,
     ///        "g": 1.0,
     ///        "b": 1.0,
     ///        "a": 1.0
     ///    },
     ///    "itemTypeIcon": {
     ///
     ///    },
     ///    "harvestParticlePrefab": {
     ///
     ///    },
     ///    "overrideHarvestParticleDepth": false,
     ///    "harvestParticleDepthOffset": -3.0,
     ///    "flattenParticleShape": false,
     ///    "availableInDemo": true,
     ///    "$type": "HarvestableItemData"
     ///}
     ///</json>
    public static ItemData mainItemData = LighthouseRuinDoorInstance.mainItemData;
    public static bool itemsInThisBelongToPlayer = true;
    public static bool canAddItemsInQuestMode = true;
    public static bool hasUnderlay = false;
    public static int columns = 2;
    public static int rows = 2;
}
