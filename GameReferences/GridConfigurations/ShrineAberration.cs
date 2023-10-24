namespace Abyss.GameReferences.GridConfigurations;
public static class ShrineAberration
{
    public static GridConfiguration ShrineAberrationInstance = (GridConfiguration)System.Linq.Enumerable.First(ScriptableObjectInstances.GridConfigurations, x => x.name == "ShrineAberration");
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[CellGroupConfiguration, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CellGroupConfiguration> cellGroupConfigs = ShrineAberrationInstance.cellGroupConfigs;
    public static ItemType mainItemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype mainItemSubtype = ItemSubtype.NONE | ItemSubtype.FISH;
     ///<json>
     /// null
     /// </json>
    public static ItemData mainItemData = null;
    public static bool itemsInThisBelongToPlayer = false;
    public static bool canAddItemsInQuestMode = true;
    public static bool hasUnderlay = false;
    public static int columns = 5;
    public static int rows = 5;
}
