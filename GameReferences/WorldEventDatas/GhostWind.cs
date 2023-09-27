namespace Abyss.GameReferences.WorldEventDatas;
public static class GhostWind
{
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
    public static UnityEngine.GameObject prefab = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "GhostWind").prefab;
    public static bool dispelByBanish = false;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 1.5f;
    public static float foghornDispelCount = 3f;
    public static int minWorldPhase = 1;
    public static float minSanity = 0.25f;
    public static float maxSanity = 1f;
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "GhostWind").repeatDelay;
    public static float weight = 3f;
    public static float spawnStartTime = 0f;
    public static float spawnEndTime = 1f;
    public static bool hasDuration = true;
    public static float durationSec = 20f;
    public static bool hasMinDepth = false;
    public static float minDepth = 0f;
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "GhostWind").depthTestPath;
    public static bool isPath = false;
    public static float depthPathNumChecks = 5f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static bool doSafeZoneHitCheck = false;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static ZoneEnum forbiddenZones = ZoneEnum.NONE;
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "GhostWind").itemInventoryConditions;
    public static bool allowInPassiveMode = true;
}
