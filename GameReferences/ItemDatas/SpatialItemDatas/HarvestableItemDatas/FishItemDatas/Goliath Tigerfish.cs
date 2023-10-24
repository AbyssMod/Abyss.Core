namespace Abyss.GameReferences.ItemDatas.SpatialItemDatas.HarvestableItemDatas.FishItemDatas;
public static class Goliath_Tigerfish
{
    public static FishItemData Goliath_TigerfishInstance = (FishItemData)System.Linq.Enumerable.First(ScriptableObjectInstances.ItemDatas, x => x.name == "Goliath_Tigerfish");
    public static float minSizeCentimeters = 100f;
    public static float maxSizeCentimeters = 200f;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[FishItemData, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<FishItemData> aberrations = Goliath_TigerfishInstance.aberrations;
    public static bool isAberration = false;
     ///<json>
     /// null
     /// </json>
    public static FishItemData nonAberrationParent = null;
    public static int minWorldPhaseRequired = 0;
    public static bool locationHiddenUntilCaught = true;
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
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> cellsExcludedFromDisplayingInfection = Goliath_TigerfishInstance.cellsExcludedFromDisplayingInfection;
    public static HarvestMinigameType harvestMinigameType = HarvestMinigameType.FISHING_RADIAL;
    public static int perSpotMin = 1;
    public static int perSpotMax = 1;
    public static float harvestItemWeight = 1f;
    public static bool regenHarvestSpotOnDestroy = false;
    public static HarvestPOICategory harvestPOICategory = HarvestPOICategory.FISH_LARGE;
    public static HarvestableType harvestableType = HarvestableType.MANGROVE;
    public static HarvestDifficulty harvestDifficulty = HarvestDifficulty.VERY_HARD;
    public static bool canBeReplacedWithResearchItem = false;
    public static bool canBeCaughtByRod = true;
    public static bool canBeCaughtByPot = false;
    public static bool canBeCaughtByNet = false;
    public static bool affectedByFishingSustain = false;
    public static ZoneEnum zonesFoundIn = ZoneEnum.NONE | ZoneEnum.TWISTED_STRAND;
    public static bool canBeSoldByPlayer = true;
    public static bool canBeSoldInBulkAction = true;
    public static System.Decimal value = 250m;
    public static bool hasSellOverride = false;
    public static System.Decimal sellOverrideValue = 0m;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite sprite = Goliath_TigerfishInstance.sprite;
    public static UnityEngine.Color itemColor = new UnityEngine.Color(0.2264151f, 0.1562912f, 0.1249555f, 255f);
    public static bool canBeDiscardedByPlayer = true;
    public static bool showAlertOnDiscardHold = true;
    public static bool discardHoldTimeOverride = true;
    public static float discardHoldTimeSec = 2f;
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
     ///        },
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
     ///    "$type": "System.Collections.Generic.List`1[[UnityEngine.Vector2Int, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> dimensions = Goliath_TigerfishInstance.dimensions;
    public static float squishFactor = 1f;
    public static string id = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemNameKey = Goliath_TigerfishInstance.itemNameKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemDescriptionKey = Goliath_TigerfishInstance.itemDescriptionKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneTitleKey = Goliath_TigerfishInstance.itemInsaneTitleKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneDescriptionKey = Goliath_TigerfishInstance.itemInsaneDescriptionKey;
    public static string linkedDialogueNode = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString dialogueNodeSpecificDescription = Goliath_TigerfishInstance.dialogueNodeSpecificDescription;
    public static ItemType itemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype itemSubtype = ItemSubtype.NONE | ItemSubtype.FISH;
    public static UnityEngine.Color tooltipTextColor = new UnityEngine.Color(0.4901961f, 0.3843137f, 0.2666667f, 1f);
    public static UnityEngine.Color tooltipNotesColor = new UnityEngine.Color(1f, 1f, 1f, 1f);
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite itemTypeIcon = Goliath_TigerfishInstance.itemTypeIcon;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.GameObject harvestParticlePrefab = Goliath_TigerfishInstance.harvestParticlePrefab;
    public static bool overrideHarvestParticleDepth = true;
    public static float harvestParticleDepthOffset = -2.25f;
    public static bool flattenParticleShape = false;
    public static bool availableInDemo = true;
}
