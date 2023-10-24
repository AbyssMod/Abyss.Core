namespace Abyss.GameReferences.AchievementDatas;
public static class RESEARCH_NETS
{
    public static AchievementData RESEARCH_NETSInstance = (AchievementData)System.Linq.Enumerable.First(ScriptableObjectInstances.AchievementDatas, x => x.name == "RESEARCH_NETS");
    public static DredgeAchievementId id = DredgeAchievementId.RESEARCH_NETS;
    public static string steamId = "";
    public static int playStationId = 24;
    public static string xboxId = "";
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "items": [
     ///                {
     ///                    "timeBetweenCatchRolls": 0.083,
     ///                    "catchRate": 1.0,
     ///                    "maxDurabilityDays": 2.0,
     ///                    "gridConfig": {
     ///                        "cellGroupConfigs": [],
     ///                        "mainItemType": "GENERAL,ALL",
     ///                        "mainItemSubtype": "FISH,ALL",
     ///                        "mainItemData": null,
     ///                        "itemsInThisBelongToPlayer": true,
     ///                        "canAddItemsInQuestMode": false,
     ///                        "hasUnderlay": false,
     ///                        "columns": 6,
     ///                        "rows": 6
     ///                    },
     ///                    "harvestableTypes": [
     ///                        "MANGROVE",
     ///                        "SHALLOW"
     ///                    ],
     ///                    "aberrationBonus": 0.0,
     ///                    "canBeSoldByPlayer": true,
     ///                    "canBeSoldInBulkAction": true,
     ///                    "value": 350.0,
     ///                    "hasSellOverride": false,
     ///                    "sellOverrideValue": 0.0,
     ///                    "sprite": {
     ///
     ///                    },
     ///                    "platformSpecificSpriteOverrides": null,
     ///                    "itemColor": {
     ///                        "r": 0.1921569,
     ///                        "g": 0.1921569,
     ///                        "b": 0.1921569,
     ///                        "a": 255.0
     ///                    },
     ///                    "canBeDiscardedByPlayer": true,
     ///                    "showAlertOnDiscardHold": true,
     ///                    "discardHoldTimeOverride": true,
     ///                    "discardHoldTimeSec": 2.0,
     ///                    "canBeDiscardedDuringQuestPickup": true,
     ///                    "damageMode": "DURABILITY",
     ///                    "moveMode": "INSTALL",
     ///                    "ignoreDamageWhenPlacing": true,
     ///                    "isUnderlayItem": false,
     ///                    "forbidStorageTray": false,
     ///                    "dimensions": [
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        }
     ///                    ],
     ///                    "squishFactor": 0.0,
     ///                    "itemOwnPrerequisites": [],
     ///                    "researchPrerequisites": [
     ///                        {
     ///                            "itemData": {
     ///                                "timeBetweenCatchRolls": 0.1,
     ///                                "catchRate": 1.0,
     ///                                "maxDurabilityDays": 2.0,
     ///                                "gridConfig": {
     ///                                    "cellGroupConfigs": [],
     ///                                    "mainItemType": "GENERAL,ALL",
     ///                                    "mainItemSubtype": "FISH,ALL",
     ///                                    "mainItemData": null,
     ///                                    "itemsInThisBelongToPlayer": true,
     ///                                    "canAddItemsInQuestMode": false,
     ///                                    "hasUnderlay": false,
     ///                                    "columns": 5,
     ///                                    "rows": 6
     ///                                },
     ///                                "harvestableTypes": [
     ///                                    "COASTAL"
     ///                                ],
     ///                                "aberrationBonus": 0.0,
     ///                                "canBeSoldByPlayer": true,
     ///                                "canBeSoldInBulkAction": true,
     ///                                "value": 300.0,
     ///                                "hasSellOverride": false,
     ///                                "sellOverrideValue": 0.0,
     ///                                "sprite": {
     ///
     ///                                },
     ///                                "platformSpecificSpriteOverrides": null,
     ///                                "itemColor": {
     ///                                    "r": 0.1921569,
     ///                                    "g": 0.1921569,
     ///                                    "b": 0.1921569,
     ///                                    "a": 255.0
     ///                                },
     ///                                "canBeDiscardedByPlayer": true,
     ///                                "showAlertOnDiscardHold": true,
     ///                                "discardHoldTimeOverride": true,
     ///                                "discardHoldTimeSec": 2.0,
     ///                                "canBeDiscardedDuringQuestPickup": true,
     ///                                "damageMode": "DURABILITY",
     ///                                "moveMode": "INSTALL",
     ///                                "ignoreDamageWhenPlacing": true,
     ///                                "isUnderlayItem": false,
     ///                                "forbidStorageTray": false,
     ///                                "dimensions": [
     ///                                    {
     ///
     ///                                    },
     ///                                    {
     ///
     ///                                    },
     ///                                    {
     ///
     ///                                    },
     ///                                    {
     ///
     ///                                    }
     ///                                ],
     ///                                "squishFactor": 0.0,
     ///                                "itemOwnPrerequisites": [],
     ///                                "researchPrerequisites": [],
     ///                                "researchPointsRequired": 1,
     ///                                "buyableWithoutResearch": false,
     ///                                "id": "net2",
     ///                                "itemNameKey": [],
     ///                                "itemDescriptionKey": [],
     ///                                "itemInsaneTitleKey": [],
     ///                                "itemInsaneDescriptionKey": [],
     ///                                "linkedDialogueNode": "",
     ///                                "dialogueNodeSpecificDescription": [],
     ///                                "itemType": "EQUIPMENT,ALL",
     ///                                "itemSubtype": "NET,ALL",
     ///                                "tooltipTextColor": {
     ///                                    "r": 0.4901961,
     ///                                    "g": 0.3843137,
     ///                                    "b": 0.2666667,
     ///                                    "a": 1.0
     ///                                },
     ///                                "tooltipNotesColor": {
     ///                                    "r": 1.0,
     ///                                    "g": 1.0,
     ///                                    "b": 1.0,
     ///                                    "a": 1.0
     ///                                },
     ///                                "itemTypeIcon": {
     ///                                    "$id": "23"
     ///                                },
     ///                                "harvestParticlePrefab": null,
     ///                                "overrideHarvestParticleDepth": false,
     ///                                "harvestParticleDepthOffset": -3.0,
     ///                                "flattenParticleShape": false,
     ///                                "availableInDemo": false,
     ///                                "$type": "DeployableItemData",
     ///                                "$id": "11"
     ///                            }
     ///                        }
     ///                    ],
     ///                    "researchPointsRequired": 2,
     ///                    "buyableWithoutResearch": false,
     ///                    "id": "net3",
     ///                    "itemNameKey": [],
     ///                    "itemDescriptionKey": [],
     ///                    "itemInsaneTitleKey": [],
     ///                    "itemInsaneDescriptionKey": [],
     ///                    "linkedDialogueNode": "",
     ///                    "dialogueNodeSpecificDescription": [],
     ///                    "itemType": "EQUIPMENT,ALL",
     ///                    "itemSubtype": "NET,ALL",
     ///                    "tooltipTextColor": {
     ///                        "r": 0.4901961,
     ///                        "g": 0.3843137,
     ///                        "b": 0.2666667,
     ///                        "a": 1.0
     ///                    },
     ///                    "tooltipNotesColor": {
     ///                        "r": 1.0,
     ///                        "g": 1.0,
     ///                        "b": 1.0,
     ///                        "a": 1.0
     ///                    },
     ///                    "itemTypeIcon": {
     ///                        "$ref": "23"
     ///                    },
     ///                    "harvestParticlePrefab": null,
     ///                    "overrideHarvestParticleDepth": false,
     ///                    "harvestParticleDepthOffset": -3.0,
     ///                    "flattenParticleShape": false,
     ///                    "availableInDemo": false,
     ///                    "$type": "DeployableItemData"
     ///                },
     ///                {
     ///                    "timeBetweenCatchRolls": 0.083,
     ///                    "catchRate": 1.0,
     ///                    "maxDurabilityDays": 2.0,
     ///                    "gridConfig": {
     ///                        "cellGroupConfigs": [],
     ///                        "mainItemType": "GENERAL,ALL",
     ///                        "mainItemSubtype": "FISH,ALL",
     ///                        "mainItemData": null,
     ///                        "itemsInThisBelongToPlayer": true,
     ///                        "canAddItemsInQuestMode": false,
     ///                        "hasUnderlay": false,
     ///                        "columns": 6,
     ///                        "rows": 6
     ///                    },
     ///                    "harvestableTypes": [
     ///                        "VOLCANIC",
     ///                        "COASTAL"
     ///                    ],
     ///                    "aberrationBonus": 0.0,
     ///                    "canBeSoldByPlayer": true,
     ///                    "canBeSoldInBulkAction": true,
     ///                    "value": 350.0,
     ///                    "hasSellOverride": false,
     ///                    "sellOverrideValue": 0.0,
     ///                    "sprite": {
     ///
     ///                    },
     ///                    "platformSpecificSpriteOverrides": null,
     ///                    "itemColor": {
     ///                        "r": 0.1921569,
     ///                        "g": 0.1921569,
     ///                        "b": 0.1921569,
     ///                        "a": 255.0
     ///                    },
     ///                    "canBeDiscardedByPlayer": true,
     ///                    "showAlertOnDiscardHold": true,
     ///                    "discardHoldTimeOverride": true,
     ///                    "discardHoldTimeSec": 2.0,
     ///                    "canBeDiscardedDuringQuestPickup": true,
     ///                    "damageMode": "DURABILITY",
     ///                    "moveMode": "INSTALL",
     ///                    "ignoreDamageWhenPlacing": true,
     ///                    "isUnderlayItem": false,
     ///                    "forbidStorageTray": false,
     ///                    "dimensions": [
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        }
     ///                    ],
     ///                    "squishFactor": 0.0,
     ///                    "itemOwnPrerequisites": [],
     ///                    "researchPrerequisites": [
     ///                        {
     ///                            "itemData": {
     ///                                "$ref": "11"
     ///                            }
     ///                        }
     ///                    ],
     ///                    "researchPointsRequired": 2,
     ///                    "buyableWithoutResearch": false,
     ///                    "id": "net4",
     ///                    "itemNameKey": [],
     ///                    "itemDescriptionKey": [],
     ///                    "itemInsaneTitleKey": [],
     ///                    "itemInsaneDescriptionKey": [],
     ///                    "linkedDialogueNode": "",
     ///                    "dialogueNodeSpecificDescription": [],
     ///                    "itemType": "EQUIPMENT,ALL",
     ///                    "itemSubtype": "NET,ALL",
     ///                    "tooltipTextColor": {
     ///                        "r": 0.4901961,
     ///                        "g": 0.3843137,
     ///                        "b": 0.2666667,
     ///                        "a": 1.0
     ///                    },
     ///                    "tooltipNotesColor": {
     ///                        "r": 1.0,
     ///                        "g": 1.0,
     ///                        "b": 1.0,
     ///                        "a": 1.0
     ///                    },
     ///                    "itemTypeIcon": {
     ///                        "$ref": "23"
     ///                    },
     ///                    "harvestParticlePrefab": null,
     ///                    "overrideHarvestParticleDepth": false,
     ///                    "harvestParticleDepthOffset": -3.0,
     ///                    "flattenParticleShape": false,
     ///                    "availableInDemo": false,
     ///                    "$type": "DeployableItemData"
     ///                },
     ///                {
     ///                    "timeBetweenCatchRolls": 0.0555,
     ///                    "catchRate": 1.0,
     ///                    "maxDurabilityDays": 3.0,
     ///                    "gridConfig": {
     ///                        "cellGroupConfigs": [],
     ///                        "mainItemType": "GENERAL,ALL",
     ///                        "mainItemSubtype": "FISH,ALL",
     ///                        "mainItemData": null,
     ///                        "itemsInThisBelongToPlayer": true,
     ///                        "canAddItemsInQuestMode": false,
     ///                        "hasUnderlay": false,
     ///                        "columns": 9,
     ///                        "rows": 10
     ///                    },
     ///                    "harvestableTypes": [
     ///                        "COASTAL",
     ///                        "OCEANIC"
     ///                    ],
     ///                    "aberrationBonus": 0.0,
     ///                    "canBeSoldByPlayer": true,
     ///                    "canBeSoldInBulkAction": true,
     ///                    "value": 800.0,
     ///                    "hasSellOverride": false,
     ///                    "sellOverrideValue": 0.0,
     ///                    "sprite": {
     ///
     ///                    },
     ///                    "platformSpecificSpriteOverrides": null,
     ///                    "itemColor": {
     ///                        "r": 0.1921569,
     ///                        "g": 0.1921569,
     ///                        "b": 0.1921569,
     ///                        "a": 255.0
     ///                    },
     ///                    "canBeDiscardedByPlayer": true,
     ///                    "showAlertOnDiscardHold": true,
     ///                    "discardHoldTimeOverride": true,
     ///                    "discardHoldTimeSec": 2.0,
     ///                    "canBeDiscardedDuringQuestPickup": true,
     ///                    "damageMode": "DURABILITY",
     ///                    "moveMode": "INSTALL",
     ///                    "ignoreDamageWhenPlacing": true,
     ///                    "isUnderlayItem": false,
     ///                    "forbidStorageTray": false,
     ///                    "dimensions": [
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        }
     ///                    ],
     ///                    "squishFactor": 0.0,
     ///                    "itemOwnPrerequisites": [],
     ///                    "researchPrerequisites": [
     ///                        {
     ///                            "itemData": {
     ///                                "timeBetweenCatchRolls": 0.083,
     ///                                "catchRate": 1.0,
     ///                                "maxDurabilityDays": 3.0,
     ///                                "gridConfig": {
     ///                                    "cellGroupConfigs": [],
     ///                                    "mainItemType": "GENERAL,ALL",
     ///                                    "mainItemSubtype": "FISH,ALL",
     ///                                    "mainItemData": null,
     ///                                    "itemsInThisBelongToPlayer": true,
     ///                                    "canAddItemsInQuestMode": false,
     ///                                    "hasUnderlay": false,
     ///                                    "columns": 8,
     ///                                    "rows": 8
     ///                                },
     ///                                "harvestableTypes": [
     ///                                    "COASTAL",
     ///                                    "SHALLOW"
     ///                                ],
     ///                                "aberrationBonus": 0.0,
     ///                                "canBeSoldByPlayer": true,
     ///                                "canBeSoldInBulkAction": true,
     ///                                "value": 400.0,
     ///                                "hasSellOverride": false,
     ///                                "sellOverrideValue": 0.0,
     ///                                "sprite": {
     ///
     ///                                },
     ///                                "platformSpecificSpriteOverrides": null,
     ///                                "itemColor": {
     ///                                    "r": 0.1921569,
     ///                                    "g": 0.1921569,
     ///                                    "b": 0.1921569,
     ///                                    "a": 255.0
     ///                                },
     ///                                "canBeDiscardedByPlayer": true,
     ///                                "showAlertOnDiscardHold": true,
     ///                                "discardHoldTimeOverride": true,
     ///                                "discardHoldTimeSec": 2.0,
     ///                                "canBeDiscardedDuringQuestPickup": true,
     ///                                "damageMode": "DURABILITY",
     ///                                "moveMode": "INSTALL",
     ///                                "ignoreDamageWhenPlacing": true,
     ///                                "isUnderlayItem": false,
     ///                                "forbidStorageTray": false,
     ///                                "dimensions": [
     ///                                    {
     ///
     ///                                    },
     ///                                    {
     ///
     ///                                    },
     ///                                    {
     ///
     ///                                    },
     ///                                    {
     ///
     ///                                    },
     ///                                    {
     ///
     ///                                    },
     ///                                    {
     ///
     ///                                    }
     ///                                ],
     ///                                "squishFactor": 0.0,
     ///                                "itemOwnPrerequisites": [],
     ///                                "researchPrerequisites": [
     ///                                    {
     ///                                        "itemData": {
     ///                                            "$ref": "11"
     ///                                        }
     ///                                    }
     ///                                ],
     ///                                "researchPointsRequired": 3,
     ///                                "buyableWithoutResearch": false,
     ///                                "id": "net5",
     ///                                "itemNameKey": [],
     ///                                "itemDescriptionKey": [],
     ///                                "itemInsaneTitleKey": [],
     ///                                "itemInsaneDescriptionKey": [],
     ///                                "linkedDialogueNode": "",
     ///                                "dialogueNodeSpecificDescription": [],
     ///                                "itemType": "EQUIPMENT,ALL",
     ///                                "itemSubtype": "NET,ALL",
     ///                                "tooltipTextColor": {
     ///                                    "r": 0.4901961,
     ///                                    "g": 0.3843137,
     ///                                    "b": 0.2666667,
     ///                                    "a": 1.0
     ///                                },
     ///                                "tooltipNotesColor": {
     ///                                    "r": 1.0,
     ///                                    "g": 1.0,
     ///                                    "b": 1.0,
     ///                                    "a": 1.0
     ///                                },
     ///                                "itemTypeIcon": {
     ///                                    "$ref": "23"
     ///                                },
     ///                                "harvestParticlePrefab": null,
     ///                                "overrideHarvestParticleDepth": false,
     ///                                "harvestParticleDepthOffset": -3.0,
     ///                                "flattenParticleShape": false,
     ///                                "availableInDemo": false,
     ///                                "$type": "DeployableItemData"
     ///                            }
     ///                        }
     ///                    ],
     ///                    "researchPointsRequired": 4,
     ///                    "buyableWithoutResearch": false,
     ///                    "id": "net6",
     ///                    "itemNameKey": [],
     ///                    "itemDescriptionKey": [],
     ///                    "itemInsaneTitleKey": [],
     ///                    "itemInsaneDescriptionKey": [],
     ///                    "linkedDialogueNode": "",
     ///                    "dialogueNodeSpecificDescription": [],
     ///                    "itemType": "EQUIPMENT,ALL",
     ///                    "itemSubtype": "NET,ALL",
     ///                    "tooltipTextColor": {
     ///                        "r": 0.4901961,
     ///                        "g": 0.3843137,
     ///                        "b": 0.2666667,
     ///                        "a": 1.0
     ///                    },
     ///                    "tooltipNotesColor": {
     ///                        "r": 1.0,
     ///                        "g": 1.0,
     ///                        "b": 1.0,
     ///                        "a": 1.0
     ///                    },
     ///                    "itemTypeIcon": {
     ///                        "$ref": "23"
     ///                    },
     ///                    "harvestParticlePrefab": null,
     ///                    "overrideHarvestParticleDepth": false,
     ///                    "harvestParticleDepthOffset": -3.0,
     ///                    "flattenParticleShape": false,
     ///                    "availableInDemo": false,
     ///                    "$type": "DeployableItemData"
     ///                }
     ///            ],
     ///            "$type": "ResearchCompleteCondition"
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[AchievementCondition, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<AchievementCondition> evaluationConditions = RESEARCH_NETSInstance.evaluationConditions;
}
