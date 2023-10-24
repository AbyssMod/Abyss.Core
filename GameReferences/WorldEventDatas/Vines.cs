namespace Abyss.GameReferences.WorldEventDatas;
public static class Vines
{
    public static WorldEventData VinesInstance = (WorldEventData)System.Linq.Enumerable.First(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Vines");
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.GameObject prefab = VinesInstance.prefab;
    public static bool dispelByBanish = true;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 0f;
    public static float foghornDispelCount = 0f;
    public static int minWorldPhase = 0;
    public static float minSanity = 0f;
    public static float maxSanity = 0.25f;
     ///<json>
     /// {
     ///    "NORMAL": 0.5,
     ///    "PASSIVE": 0.5,
     ///    "NIGHTMARE": 0.2,
     ///    "$type": "System.Collections.Generic.Dictionary`2[[GameMode, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]"
     ///}
     ///</json>
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = VinesInstance.repeatDelay;
    public static float weight = 25f;
    public static float spawnStartTime = 0f;
    public static float spawnEndTime = 1f;
    public static bool hasDuration = false;
    public static float durationSec = 0f;
    public static bool hasMinDepth = true;
    public static float minDepth = 0.04f;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "x": 0.0,
     ///            "y": 0.0,
     ///            "z": 0.0
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = VinesInstance.depthTestPath;
    public static bool isPath = false;
    public static float depthPathNumChecks = 1f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static bool doSafeZoneHitCheck = true;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static ZoneEnum forbiddenZones = ZoneEnum.NONE | ZoneEnum.THE_MARROWS | ZoneEnum.GALE_CLIFFS | ZoneEnum.STELLAR_BASIN | ZoneEnum.DEVILS_SPINE | ZoneEnum.OPEN_OCEAN;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[InventoryCondition, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = VinesInstance.itemInventoryConditions;
    public static bool allowInPassiveMode = false;
}
