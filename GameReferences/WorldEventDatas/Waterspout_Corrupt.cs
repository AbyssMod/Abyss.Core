namespace Abyss.GameReferences.WorldEventDatas;
public static class Waterspout_Corrupt
{
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
    public static UnityEngine.GameObject prefab = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Waterspout_Corrupt").prefab;
    public static bool dispelByBanish = true;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 0f;
    public static float foghornDispelCount = 0f;
    public static int minWorldPhase = 2;
    public static float minSanity = 0f;
    public static float maxSanity = 0.5f;
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Waterspout_Corrupt").repeatDelay;
    public static float weight = 7f;
    public static float spawnStartTime = 0f;
    public static float spawnEndTime = 1f;
    public static bool hasDuration = true;
    public static float durationSec = 40f;
    public static bool hasMinDepth = true;
    public static float minDepth = 0.01f;
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Waterspout_Corrupt").depthTestPath;
    public static bool isPath = false;
    public static float depthPathNumChecks = 1f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(-5f, 0f, 40f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(-5f, 0f, 40f);
    public static bool doSafeZoneHitCheck = true;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(-5f, 0f, 40f);
    public static ZoneEnum forbiddenZones = ZoneEnum.GALE_CLIFFS, TWISTED_STRAND;
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Waterspout_Corrupt").itemInventoryConditions;
    public static bool allowInPassiveMode = false;
}
