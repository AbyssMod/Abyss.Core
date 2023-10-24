namespace Abyss.GameReferences.ItemDatas.SpatialItemDatas.HarvestableItemDatas;
public static class Ring4
{
    public static HarvestableItemData Ring4Instance = (HarvestableItemData)System.Linq.Enumerable.First(ScriptableObjectInstances.ItemDatas, x => x.name == "Ring4");
    public static HarvestMinigameType harvestMinigameType = HarvestMinigameType.DREDGE_RADIAL;
    public static int perSpotMin = 1;
    public static int perSpotMax = 1;
    public static float harvestItemWeight = 1f;
    public static bool regenHarvestSpotOnDestroy = false;
    public static HarvestPOICategory harvestPOICategory = HarvestPOICategory.TRINKET;
    public static HarvestableType harvestableType = HarvestableType.DREDGE;
    public static HarvestDifficulty harvestDifficulty = HarvestDifficulty.HARD;
    public static bool canBeReplacedWithResearchItem = false;
    public static bool canBeCaughtByRod = false;
    public static bool canBeCaughtByPot = false;
    public static bool canBeCaughtByNet = false;
    public static bool affectedByFishingSustain = true;
    public static bool hasMinDepth = false;
    public static DepthEnum minDepth = DepthEnum.VERY_SHALLOW;
    public static bool hasMaxDepth = false;
    public static DepthEnum maxDepth = DepthEnum.VERY_SHALLOW;
    public static ZoneEnum zonesFoundIn = ZoneEnum.NONE;
    public static bool canBeSoldByPlayer = true;
    public static bool canBeSoldInBulkAction = true;
    public static System.Decimal value = 45m;
    public static bool hasSellOverride = false;
    public static System.Decimal sellOverrideValue = 0m;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite sprite = Ring4Instance.sprite;
    public static UnityEngine.Color itemColor = new UnityEngine.Color(0.227451f, 0.1568628f, 0.1254902f, 255f);
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
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> dimensions = Ring4Instance.dimensions;
    public static float squishFactor = 0f;
    public static string id = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemNameKey = Ring4Instance.itemNameKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemDescriptionKey = Ring4Instance.itemDescriptionKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneTitleKey = Ring4Instance.itemInsaneTitleKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneDescriptionKey = Ring4Instance.itemInsaneDescriptionKey;
    public static string linkedDialogueNode = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString dialogueNodeSpecificDescription = Ring4Instance.dialogueNodeSpecificDescription;
    public static ItemType itemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype itemSubtype = ItemSubtype.NONE | ItemSubtype.TRINKET;
    public static UnityEngine.Color tooltipTextColor = new UnityEngine.Color(0.4901961f, 0.3843137f, 0.2666667f, 1f);
    public static UnityEngine.Color tooltipNotesColor = new UnityEngine.Color(1f, 1f, 1f, 1f);
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite itemTypeIcon = Ring4Instance.itemTypeIcon;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.GameObject harvestParticlePrefab = Ring4Instance.harvestParticlePrefab;
    public static bool overrideHarvestParticleDepth = false;
    public static float harvestParticleDepthOffset = -3f;
    public static bool flattenParticleShape = false;
    public static bool availableInDemo = true;
}
