namespace Abyss.GameReferences.ItemDatas.SpatialItemDatas.HarvestableItemDatas.FishItemDatas;
public static class Anchovy
{
    public static FishItemData AnchovyInstance = (FishItemData)System.Linq.Enumerable.First(ScriptableObjectInstances.ItemDatas, x => x.name == "Anchovy");
    public static float minSizeCentimeters = 5f;
    public static float maxSizeCentimeters = 15f;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "minSizeCentimeters": 5.0,
     ///            "maxSizeCentimeters": 15.0,
     ///            "aberrations": [],
     ///            "isAberration": true,
     ///            "nonAberrationParent": {
     ///                "minSizeCentimeters": 5.0,
     ///                "maxSizeCentimeters": 15.0,
     ///                "aberrations": {
     ///                    "$ref": "0"
     ///                },
     ///                "isAberration": false,
     ///                "nonAberrationParent": null,
     ///                "minWorldPhaseRequired": 0,
     ///                "locationHiddenUntilCaught": false,
     ///                "day": true,
     ///                "night": true,
     ///                "canAppearInBaitBalls": false,
     ///                "canBeInfected": true,
     ///                "cellsExcludedFromDisplayingInfection": [],
     ///                "harvestMinigameType": "FISHING_RADIAL",
     ///                "perSpotMin": 0,
     ///                "perSpotMax": 0,
     ///                "harvestItemWeight": 5.0,
     ///                "regenHarvestSpotOnDestroy": false,
     ///                "harvestPOICategory": "FISH_SMALL",
     ///                "harvestableType": "OCEANIC",
     ///                "harvestDifficulty": "VERY_EASY",
     ///                "canBeReplacedWithResearchItem": false,
     ///                "canBeCaughtByRod": false,
     ///                "canBeCaughtByPot": false,
     ///                "canBeCaughtByNet": true,
     ///                "affectedByFishingSustain": true,
     ///                "hasMinDepth": true,
     ///                "minDepth": "SHALLOW",
     ///                "hasMaxDepth": true,
     ///                "maxDepth": "DEEP",
     ///                "zonesFoundIn": "OPEN_OCEAN,ALL",
     ///                "canBeSoldByPlayer": true,
     ///                "canBeSoldInBulkAction": true,
     ///                "value": 6.5,
     ///                "hasSellOverride": false,
     ///                "sellOverrideValue": 0.0,
     ///                "sprite": {
     ///
     ///                },
     ///                "platformSpecificSpriteOverrides": null,
     ///                "itemColor": {
     ///                    "r": 0.2264151,
     ///                    "g": 0.1562912,
     ///                    "b": 0.1249555,
     ///                    "a": 255.0
     ///                },
     ///                "canBeDiscardedByPlayer": true,
     ///                "showAlertOnDiscardHold": false,
     ///                "discardHoldTimeOverride": false,
     ///                "discardHoldTimeSec": 0.0,
     ///                "canBeDiscardedDuringQuestPickup": true,
     ///                "damageMode": "DESTROY",
     ///                "moveMode": "FREE",
     ///                "ignoreDamageWhenPlacing": false,
     ///                "isUnderlayItem": false,
     ///                "forbidStorageTray": false,
     ///                "dimensions": [
     ///                    {
     ///
     ///                    }
     ///                ],
     ///                "squishFactor": 1.0,
     ///                "itemOwnPrerequisites": [],
     ///                "researchPrerequisites": [],
     ///                "researchPointsRequired": 0,
     ///                "buyableWithoutResearch": false,
     ///                "id": "anchovy",
     ///                "itemNameKey": [],
     ///                "itemDescriptionKey": [],
     ///                "itemInsaneTitleKey": [],
     ///                "itemInsaneDescriptionKey": [],
     ///                "linkedDialogueNode": "",
     ///                "dialogueNodeSpecificDescription": [],
     ///                "itemType": "GENERAL,ALL",
     ///                "itemSubtype": "FISH,ALL",
     ///                "tooltipTextColor": {
     ///                    "r": 0.4901961,
     ///                    "g": 0.3843137,
     ///                    "b": 0.2666667,
     ///                    "a": 1.0
     ///                },
     ///                "tooltipNotesColor": {
     ///                    "r": 1.0,
     ///                    "g": 1.0,
     ///                    "b": 1.0,
     ///                    "a": 1.0
     ///                },
     ///                "itemTypeIcon": {
     ///                    "$id": "14"
     ///                },
     ///                "harvestParticlePrefab": {
     ///                    "$id": "15"
     ///                },
     ///                "overrideHarvestParticleDepth": false,
     ///                "harvestParticleDepthOffset": -5.0,
     ///                "flattenParticleShape": false,
     ///                "availableInDemo": true
     ///            },
     ///            "minWorldPhaseRequired": 0,
     ///            "locationHiddenUntilCaught": false,
     ///            "day": true,
     ///            "night": true,
     ///            "canAppearInBaitBalls": false,
     ///            "canBeInfected": true,
     ///            "cellsExcludedFromDisplayingInfection": [],
     ///            "harvestMinigameType": "FISHING_RADIAL",
     ///            "perSpotMin": 0,
     ///            "perSpotMax": 0,
     ///            "harvestItemWeight": 5.0,
     ///            "regenHarvestSpotOnDestroy": false,
     ///            "harvestPOICategory": "FISH_SMALL",
     ///            "harvestableType": "OCEANIC",
     ///            "harvestDifficulty": "VERY_EASY",
     ///            "canBeReplacedWithResearchItem": false,
     ///            "canBeCaughtByRod": false,
     ///            "canBeCaughtByPot": false,
     ///            "canBeCaughtByNet": true,
     ///            "affectedByFishingSustain": true,
     ///            "hasMinDepth": false,
     ///            "minDepth": "SHALLOW",
     ///            "hasMaxDepth": false,
     ///            "maxDepth": "MEDIUM",
     ///            "zonesFoundIn": "OPEN_OCEAN,ALL",
     ///            "canBeSoldByPlayer": true,
     ///            "canBeSoldInBulkAction": true,
     ///            "value": 18.0,
     ///            "hasSellOverride": false,
     ///            "sellOverrideValue": 0.0,
     ///            "sprite": {
     ///
     ///            },
     ///            "platformSpecificSpriteOverrides": null,
     ///            "itemColor": {
     ///                "r": 0.5333334,
     ///                "g": 0.0,
     ///                "b": 0.2980392,
     ///                "a": 1.0
     ///            },
     ///            "canBeDiscardedByPlayer": true,
     ///            "showAlertOnDiscardHold": false,
     ///            "discardHoldTimeOverride": false,
     ///            "discardHoldTimeSec": 0.0,
     ///            "canBeDiscardedDuringQuestPickup": true,
     ///            "damageMode": "DESTROY",
     ///            "moveMode": "FREE",
     ///            "ignoreDamageWhenPlacing": false,
     ///            "isUnderlayItem": false,
     ///            "forbidStorageTray": false,
     ///            "dimensions": [
     ///                {
     ///
     ///                }
     ///            ],
     ///            "squishFactor": 1.0,
     ///            "itemOwnPrerequisites": [],
     ///            "researchPrerequisites": [],
     ///            "researchPointsRequired": 0,
     ///            "buyableWithoutResearch": false,
     ///            "id": "anchovy-ab-1",
     ///            "itemNameKey": [],
     ///            "itemDescriptionKey": [],
     ///            "itemInsaneTitleKey": [],
     ///            "itemInsaneDescriptionKey": [],
     ///            "linkedDialogueNode": "",
     ///            "dialogueNodeSpecificDescription": [],
     ///            "itemType": "GENERAL,ALL",
     ///            "itemSubtype": "FISH,ALL",
     ///            "tooltipTextColor": {
     ///                "r": 0.5333334,
     ///                "g": 0.0,
     ///                "b": 0.2980392,
     ///                "a": 1.0
     ///            },
     ///            "tooltipNotesColor": {
     ///                "r": 1.0,
     ///                "g": 1.0,
     ///                "b": 1.0,
     ///                "a": 1.0
     ///            },
     ///            "itemTypeIcon": {
     ///                "$ref": "14"
     ///            },
     ///            "harvestParticlePrefab": {
     ///                "$ref": "15"
     ///            },
     ///            "overrideHarvestParticleDepth": false,
     ///            "harvestParticleDepthOffset": -5.0,
     ///            "flattenParticleShape": false,
     ///            "availableInDemo": true
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[FishItemData, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]",
     ///    "$id": "0"
     ///}
     ///</json>
    public static System.Collections.Generic.List<FishItemData> aberrations = AnchovyInstance.aberrations;
    public static bool isAberration = false;
     ///<json>
     /// null
     /// </json>
    public static FishItemData nonAberrationParent = null;
    public static int minWorldPhaseRequired = 0;
    public static bool locationHiddenUntilCaught = false;
    public static bool day = true;
    public static bool night = true;
    public static bool canAppearInBaitBalls = false;
    public static bool canBeInfected = true;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[UnityEngine.Vector2Int, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> cellsExcludedFromDisplayingInfection = AnchovyInstance.cellsExcludedFromDisplayingInfection;
    public static HarvestMinigameType harvestMinigameType = HarvestMinigameType.FISHING_RADIAL;
    public static int perSpotMin = 0;
    public static int perSpotMax = 0;
    public static float harvestItemWeight = 5f;
    public static bool regenHarvestSpotOnDestroy = false;
    public static HarvestPOICategory harvestPOICategory = HarvestPOICategory.FISH_SMALL;
    public static HarvestableType harvestableType = HarvestableType.OCEANIC;
    public static HarvestDifficulty harvestDifficulty = HarvestDifficulty.VERY_EASY;
    public static bool canBeReplacedWithResearchItem = false;
    public static bool canBeCaughtByRod = false;
    public static bool canBeCaughtByPot = false;
    public static bool canBeCaughtByNet = true;
    public static bool affectedByFishingSustain = true;
    public static ZoneEnum zonesFoundIn = ZoneEnum.NONE | ZoneEnum.OPEN_OCEAN;
    public static bool canBeSoldByPlayer = true;
    public static bool canBeSoldInBulkAction = true;
    public static System.Decimal value = 6.5m;
    public static bool hasSellOverride = false;
    public static System.Decimal sellOverrideValue = 0m;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite sprite = AnchovyInstance.sprite;
    public static UnityEngine.Color itemColor = new UnityEngine.Color(0.2264151f, 0.1562912f, 0.1249555f, 255f);
    public static bool canBeDiscardedByPlayer = true;
    public static bool showAlertOnDiscardHold = false;
    public static bool discardHoldTimeOverride = false;
    public static float discardHoldTimeSec = 0f;
    public static bool canBeDiscardedDuringQuestPickup = true;
    public static DamageMode damageMode = DamageMode.DESTROY;
    public static MoveMode moveMode = MoveMode.FREE;
    public static bool ignoreDamageWhenPlacing = false;
    public static bool isUnderlayItem = false;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[UnityEngine.Vector2Int, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> dimensions = AnchovyInstance.dimensions;
    public static float squishFactor = 1f;
    public static string id = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemNameKey = AnchovyInstance.itemNameKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemDescriptionKey = AnchovyInstance.itemDescriptionKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneTitleKey = AnchovyInstance.itemInsaneTitleKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneDescriptionKey = AnchovyInstance.itemInsaneDescriptionKey;
    public static string linkedDialogueNode = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString dialogueNodeSpecificDescription = AnchovyInstance.dialogueNodeSpecificDescription;
    public static ItemType itemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype itemSubtype = ItemSubtype.NONE | ItemSubtype.FISH;
    public static UnityEngine.Color tooltipTextColor = new UnityEngine.Color(0.4901961f, 0.3843137f, 0.2666667f, 1f);
    public static UnityEngine.Color tooltipNotesColor = new UnityEngine.Color(1f, 1f, 1f, 1f);
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite itemTypeIcon = AnchovyInstance.itemTypeIcon;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.GameObject harvestParticlePrefab = AnchovyInstance.harvestParticlePrefab;
    public static bool overrideHarvestParticleDepth = false;
    public static float harvestParticleDepthOffset = -5f;
    public static bool flattenParticleShape = false;
    public static bool availableInDemo = true;
}
