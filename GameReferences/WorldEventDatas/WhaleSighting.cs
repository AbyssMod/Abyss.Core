namespace Abyss.GameReferences.WorldEventDatas;
public static class WhaleSighting
{
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
    public static UnityEngine.GameObject prefab = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "WhaleSighting").prefab;
    public static bool dispelByBanish = false;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 0f;
    public static float foghornDispelCount = 0f;
    public static int minWorldPhase = 0;
    public static float minSanity = 0.75f;
    public static float maxSanity = 1f;
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "WhaleSighting").repeatDelay;
    public static float weight = 100f;
    public static float spawnStartTime = 0.35f;
    public static float spawnEndTime = 0.7f;
    public static bool hasDuration = false;
    public static float durationSec = 0f;
    public static bool hasMinDepth = true;
    public static float minDepth = 0.35f;
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "WhaleSighting").depthTestPath;
    public static bool isPath = false;
    public static float depthPathNumChecks = 5f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(5f, -22f, 85f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(5f, 0f, 85f);
    public static bool doSafeZoneHitCheck = true;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(5f, 0f, 85f);
    public static ZoneEnum forbiddenZones = ZoneEnum.GALE_CLIFFS, STELLAR_BASIN;
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "WhaleSighting").itemInventoryConditions;
    public static bool allowInPassiveMode = true;
}
