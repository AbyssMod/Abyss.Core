namespace Abyss.GameReferences.ItemDatas.SpatialItemDatas.HarvesterItemDatas.RodItemDatas;
public static class Rod19
{
    public static RodItemData Rod19Instance = (RodItemData)System.Linq.Enumerable.First(ScriptableObjectInstances.ItemDatas, x => x.name == "Rod19");
    public static float fishingSpeedModifier = 0.05f;
     ///<json>
     /// {
     ///    "$content": [
     ///        "COASTAL",
     ///        "SHALLOW"
     ///    ],
     ///    "$type": "HarvestableType[]"
     ///}
     ///</json>
    public static HarvestableType[] harvestableTypes = Rod19Instance.harvestableTypes;
    public static float aberrationBonus = 0.015f;
    public static bool canBeSoldByPlayer = true;
    public static bool canBeSoldInBulkAction = false;
    public static System.Decimal value = 80m;
    public static bool hasSellOverride = false;
    public static System.Decimal sellOverrideValue = 0m;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite sprite = Rod19Instance.sprite;
    public static UnityEngine.Color itemColor = new UnityEngine.Color(0.1921569f, 0.1921569f, 0.1921569f, 255f);
    public static bool canBeDiscardedByPlayer = true;
    public static bool showAlertOnDiscardHold = true;
    public static bool discardHoldTimeOverride = true;
    public static float discardHoldTimeSec = 2f;
    public static bool canBeDiscardedDuringQuestPickup = true;
    public static DamageMode damageMode = DamageMode.OPERATION;
    public static MoveMode moveMode = MoveMode.INSTALL;
    public static bool ignoreDamageWhenPlacing = true;
    public static bool isUnderlayItem = false;
     ///<json>
     /// {
     ///    "$content": [
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
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> dimensions = Rod19Instance.dimensions;
    public static float squishFactor = 0f;
    public static string id = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemNameKey = Rod19Instance.itemNameKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemDescriptionKey = Rod19Instance.itemDescriptionKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneTitleKey = Rod19Instance.itemInsaneTitleKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneDescriptionKey = Rod19Instance.itemInsaneDescriptionKey;
    public static string linkedDialogueNode = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString dialogueNodeSpecificDescription = Rod19Instance.dialogueNodeSpecificDescription;
    public static ItemType itemType = ItemType.NONE | ItemType.EQUIPMENT;
    public static ItemSubtype itemSubtype = ItemSubtype.NONE | ItemSubtype.ROD;
    public static UnityEngine.Color tooltipTextColor = new UnityEngine.Color(0.5333334f, 0f, 0.2980392f, 1f);
    public static UnityEngine.Color tooltipNotesColor = new UnityEngine.Color(1f, 1f, 1f, 1f);
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite itemTypeIcon = Rod19Instance.itemTypeIcon;
     ///<json>
     /// null
     /// </json>
    public static UnityEngine.GameObject harvestParticlePrefab = null;
    public static bool overrideHarvestParticleDepth = false;
    public static float harvestParticleDepthOffset = -3f;
    public static bool flattenParticleShape = false;
    public static bool availableInDemo = true;
}