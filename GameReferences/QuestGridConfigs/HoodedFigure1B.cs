namespace Abyss.GameReferences.QuestGridConfigs;
public static class HoodedFigure1B
{
    public static QuestGridConfig HoodedFigure1BInstance = (QuestGridConfig)System.Linq.Enumerable.First(ScriptableObjectInstances.QuestGridConfigs, x => x.name == "HoodedFigure1B");
    public static QuestGridExitMode questGridExitMode = QuestGridExitMode.ITEM_DELIVER;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString titleString = HoodedFigure1BInstance.titleString;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString helpStringOverride = HoodedFigure1BInstance.helpStringOverride;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString exitPromptOverride = HoodedFigure1BInstance.exitPromptOverride;
     ///<json>
     /// null
     /// </json>
    public static UnityEngine.Sprite backgroundImage = null;
    public static float gridHeightOverride = 0f;
    public static bool overrideGridCellColor = false;
    public static DredgeColorTypeEnum gridCellColor = DredgeColorTypeEnum.NEUTRAL;
    public static bool allowStorageAccess = false;
    public static bool isSaved = false;
    public static bool createItemsIfEmpty = false;
    public static GridKey gridKey = GridKey.SHRINE_DS_1;
    public static bool allowManualExit = true;
    public static bool allowEquipmentInstallation = false;
    public static bool createWithDurabilityValue = false;
    public static float startingDurabilityProportion = 1f;
     ///<json>
     /// {
     ///    "cellGroupConfigs": [],
     ///    "mainItemType": "GENERAL,ALL",
     ///    "mainItemSubtype": "FISH,ALL",
     ///    "mainItemData": null,
     ///    "itemsInThisBelongToPlayer": false,
     ///    "canAddItemsInQuestMode": true,
     ///    "hasUnderlay": false,
     ///    "columns": 2,
     ///    "rows": 1,
     ///    "$type": "GridConfiguration"
     ///}
     ///</json>
    public static GridConfiguration gridConfiguration = HoodedFigure1BInstance.gridConfiguration;
     ///<json>
     /// {
     ///    "spatialUnderlayItems": [],
     ///    "spatialItems": [
     ///        {
     ///            "x": 0,
     ///            "y": 0,
     ///            "z": 0,
     ///            "durability": 0.0,
     ///            "seen": false,
     ///            "id": "tiger-mackerel"
     ///        }
     ///    ],
     ///    "$type": "SerializableGrid"
     ///}
     ///</json>
    public static SerializableGrid presetGrid = HoodedFigure1BInstance.presetGrid;
    public static PresetGridMode presetGridMode = PresetGridMode.SILHOUETTE;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "item": {
     ///                "minSizeCentimeters": 20.0,
     ///                "maxSizeCentimeters": 40.0,
     ///                "aberrations": [
     ///                    {
     ///                        "minSizeCentimeters": 20.0,
     ///                        "maxSizeCentimeters": 40.0,
     ///                        "aberrations": [],
     ///                        "isAberration": true,
     ///                        "nonAberrationParent": {
     ///                            "$ref": "2"
     ///                        },
     ///                        "minWorldPhaseRequired": 0,
     ///                        "locationHiddenUntilCaught": false,
     ///                        "day": true,
     ///                        "night": false,
     ///                        "canAppearInBaitBalls": false,
     ///                        "canBeInfected": true,
     ///                        "cellsExcludedFromDisplayingInfection": [],
     ///                        "harvestMinigameType": "FISHING_PENDULUM",
     ///                        "perSpotMin": 3,
     ///                        "perSpotMax": 5,
     ///                        "harvestItemWeight": 1.0,
     ///                        "regenHarvestSpotOnDestroy": false,
     ///                        "harvestPOICategory": "NONE",
     ///                        "harvestableType": "COASTAL",
     ///                        "harvestDifficulty": "MEDIUM",
     ///                        "canBeReplacedWithResearchItem": false,
     ///                        "canBeCaughtByRod": true,
     ///                        "canBeCaughtByPot": false,
     ///                        "canBeCaughtByNet": true,
     ///                        "affectedByFishingSustain": true,
     ///                        "hasMinDepth": false,
     ///                        "minDepth": "SHALLOW",
     ///                        "hasMaxDepth": false,
     ///                        "maxDepth": null,
     ///                        "zonesFoundIn": "GALE_CLIFFS,ALL",
     ///                        "canBeSoldByPlayer": true,
     ///                        "canBeSoldInBulkAction": true,
     ///                        "value": 35.0,
     ///                        "hasSellOverride": false,
     ///                        "sellOverrideValue": 0.0,
     ///                        "sprite": {
     ///
     ///                        },
     ///                        "platformSpecificSpriteOverrides": null,
     ///                        "itemColor": {
     ///                            "r": 0.5333334,
     ///                            "g": 0.0,
     ///                            "b": 0.2980392,
     ///                            "a": 1.0
     ///                        },
     ///                        "canBeDiscardedByPlayer": true,
     ///                        "showAlertOnDiscardHold": false,
     ///                        "discardHoldTimeOverride": false,
     ///                        "discardHoldTimeSec": 0.0,
     ///                        "canBeDiscardedDuringQuestPickup": true,
     ///                        "damageMode": "DESTROY",
     ///                        "moveMode": "FREE",
     ///                        "ignoreDamageWhenPlacing": false,
     ///                        "isUnderlayItem": false,
     ///                        "forbidStorageTray": false,
     ///                        "dimensions": [
     ///                            {
     ///
     ///                            },
     ///                            {
     ///
     ///                            }
     ///                        ],
     ///                        "squishFactor": 1.0,
     ///                        "itemOwnPrerequisites": [],
     ///                        "researchPrerequisites": [],
     ///                        "researchPointsRequired": 0,
     ///                        "buyableWithoutResearch": false,
     ///                        "id": "tiger-mackerel-ab-1",
     ///                        "itemNameKey": [],
     ///                        "itemDescriptionKey": [],
     ///                        "itemInsaneTitleKey": [],
     ///                        "itemInsaneDescriptionKey": [],
     ///                        "linkedDialogueNode": "",
     ///                        "dialogueNodeSpecificDescription": [],
     ///                        "itemType": "GENERAL,ALL",
     ///                        "itemSubtype": "FISH,ALL",
     ///                        "tooltipTextColor": {
     ///                            "r": 0.5333334,
     ///                            "g": 0.0,
     ///                            "b": 0.2980392,
     ///                            "a": 1.0
     ///                        },
     ///                        "tooltipNotesColor": {
     ///                            "r": 1.0,
     ///                            "g": 1.0,
     ///                            "b": 1.0,
     ///                            "a": 1.0
     ///                        },
     ///                        "itemTypeIcon": {
     ///                            "$id": "16"
     ///                        },
     ///                        "harvestParticlePrefab": {
     ///                            "$id": "17"
     ///                        },
     ///                        "overrideHarvestParticleDepth": false,
     ///                        "harvestParticleDepthOffset": -3.0,
     ///                        "flattenParticleShape": false,
     ///                        "availableInDemo": true
     ///                    },
     ///                    {
     ///                        "minSizeCentimeters": 20.0,
     ///                        "maxSizeCentimeters": 40.0,
     ///                        "aberrations": [],
     ///                        "isAberration": true,
     ///                        "nonAberrationParent": {
     ///                            "$ref": "2"
     ///                        },
     ///                        "minWorldPhaseRequired": 1,
     ///                        "locationHiddenUntilCaught": false,
     ///                        "day": true,
     ///                        "night": false,
     ///                        "canAppearInBaitBalls": false,
     ///                        "canBeInfected": true,
     ///                        "cellsExcludedFromDisplayingInfection": [],
     ///                        "harvestMinigameType": "FISHING_PENDULUM",
     ///                        "perSpotMin": 3,
     ///                        "perSpotMax": 5,
     ///                        "harvestItemWeight": 1.0,
     ///                        "regenHarvestSpotOnDestroy": false,
     ///                        "harvestPOICategory": "NONE",
     ///                        "harvestableType": "COASTAL",
     ///                        "harvestDifficulty": "MEDIUM",
     ///                        "canBeReplacedWithResearchItem": false,
     ///                        "canBeCaughtByRod": true,
     ///                        "canBeCaughtByPot": false,
     ///                        "canBeCaughtByNet": true,
     ///                        "affectedByFishingSustain": true,
     ///                        "hasMinDepth": false,
     ///                        "minDepth": "SHALLOW",
     ///                        "hasMaxDepth": false,
     ///                        "maxDepth": null,
     ///                        "zonesFoundIn": "GALE_CLIFFS,ALL",
     ///                        "canBeSoldByPlayer": true,
     ///                        "canBeSoldInBulkAction": true,
     ///                        "value": 45.0,
     ///                        "hasSellOverride": false,
     ///                        "sellOverrideValue": 0.0,
     ///                        "sprite": {
     ///
     ///                        },
     ///                        "platformSpecificSpriteOverrides": null,
     ///                        "itemColor": {
     ///                            "r": 0.5333334,
     ///                            "g": 0.0,
     ///                            "b": 0.2980392,
     ///                            "a": 1.0
     ///                        },
     ///                        "canBeDiscardedByPlayer": true,
     ///                        "showAlertOnDiscardHold": false,
     ///                        "discardHoldTimeOverride": false,
     ///                        "discardHoldTimeSec": 0.0,
     ///                        "canBeDiscardedDuringQuestPickup": true,
     ///                        "damageMode": "DESTROY",
     ///                        "moveMode": "FREE",
     ///                        "ignoreDamageWhenPlacing": false,
     ///                        "isUnderlayItem": false,
     ///                        "forbidStorageTray": false,
     ///                        "dimensions": [
     ///                            {
     ///
     ///                            },
     ///                            {
     ///
     ///                            }
     ///                        ],
     ///                        "squishFactor": 1.0,
     ///                        "itemOwnPrerequisites": [],
     ///                        "researchPrerequisites": [],
     ///                        "researchPointsRequired": 0,
     ///                        "buyableWithoutResearch": false,
     ///                        "id": "tiger-mackerel-ab-2",
     ///                        "itemNameKey": [],
     ///                        "itemDescriptionKey": [],
     ///                        "itemInsaneTitleKey": [],
     ///                        "itemInsaneDescriptionKey": [],
     ///                        "linkedDialogueNode": "",
     ///                        "dialogueNodeSpecificDescription": [],
     ///                        "itemType": "GENERAL,ALL",
     ///                        "itemSubtype": "FISH,ALL",
     ///                        "tooltipTextColor": {
     ///                            "r": 0.5333334,
     ///                            "g": 0.0,
     ///                            "b": 0.2980392,
     ///                            "a": 1.0
     ///                        },
     ///                        "tooltipNotesColor": {
     ///                            "r": 1.0,
     ///                            "g": 1.0,
     ///                            "b": 1.0,
     ///                            "a": 1.0
     ///                        },
     ///                        "itemTypeIcon": {
     ///                            "$ref": "16"
     ///                        },
     ///                        "harvestParticlePrefab": {
     ///                            "$ref": "17"
     ///                        },
     ///                        "overrideHarvestParticleDepth": false,
     ///                        "harvestParticleDepthOffset": -3.0,
     ///                        "flattenParticleShape": false,
     ///                        "availableInDemo": true
     ///                    }
     ///                ],
     ///                "isAberration": false,
     ///                "nonAberrationParent": null,
     ///                "minWorldPhaseRequired": 0,
     ///                "locationHiddenUntilCaught": false,
     ///                "day": true,
     ///                "night": false,
     ///                "canAppearInBaitBalls": true,
     ///                "canBeInfected": true,
     ///                "cellsExcludedFromDisplayingInfection": [],
     ///                "harvestMinigameType": "FISHING_PENDULUM",
     ///                "perSpotMin": 3,
     ///                "perSpotMax": 5,
     ///                "harvestItemWeight": 3.0,
     ///                "regenHarvestSpotOnDestroy": false,
     ///                "harvestPOICategory": "FISH_SMALL",
     ///                "harvestableType": "COASTAL",
     ///                "harvestDifficulty": "MEDIUM",
     ///                "canBeReplacedWithResearchItem": false,
     ///                "canBeCaughtByRod": true,
     ///                "canBeCaughtByPot": false,
     ///                "canBeCaughtByNet": true,
     ///                "affectedByFishingSustain": true,
     ///                "hasMinDepth": false,
     ///                "minDepth": "SHALLOW",
     ///                "hasMaxDepth": false,
     ///                "maxDepth": null,
     ///                "zonesFoundIn": "GALE_CLIFFS,ALL",
     ///                "canBeSoldByPlayer": true,
     ///                "canBeSoldInBulkAction": true,
     ///                "value": 12.5,
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
     ///                    },
     ///                    {
     ///
     ///                    }
     ///                ],
     ///                "squishFactor": 1.0,
     ///                "itemOwnPrerequisites": [],
     ///                "researchPrerequisites": [],
     ///                "researchPointsRequired": 0,
     ///                "buyableWithoutResearch": false,
     ///                "id": "tiger-mackerel",
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
     ///                    "$ref": "16"
     ///                },
     ///                "harvestParticlePrefab": {
     ///
     ///                },
     ///                "overrideHarvestParticleDepth": false,
     ///                "harvestParticleDepthOffset": -3.0,
     ///                "flattenParticleShape": false,
     ///                "availableInDemo": true,
     ///                "$type": "FishItemData",
     ///                "$id": "2"
     ///            },
     ///            "count": 1,
     ///            "allowLinkedAberrations": true,
     ///            "$type": "ItemCountCondition"
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[CompletedGridCondition, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CompletedGridCondition> completeConditions = HoodedFigure1BInstance.completeConditions;
}