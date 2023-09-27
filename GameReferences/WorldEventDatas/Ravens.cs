namespace Abyss.GameReferences.WorldEventDatas;
public static class Ravens
{
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
    public static UnityEngine.GameObject prefab = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Ravens").prefab;
    public static bool dispelByBanish = true;
    public static bool dispelByFoghorn = true;
    public static float foghornDispelTime = 1.5f;
    public static float foghornDispelCount = 3f;
    public static int minWorldPhase = 0;
    public static float minSanity = 0f;
    public static float maxSanity = 0.5f;
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Ravens").repeatDelay;
    public static float weight = 5f;
    public static float spawnStartTime = 0.25f;
    public static float spawnEndTime = 0.75f;
    public static bool hasDuration = false;
    public static float durationSec = 0f;
    public static bool hasMinDepth = false;
    public static float minDepth = 0f;
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Ravens").depthTestPath;
    public static bool isPath = false;
    public static float depthPathNumChecks = 5f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static bool doSafeZoneHitCheck = false;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static ZoneEnum forbiddenZones = ZoneEnum.NONE;
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Ravens").itemInventoryConditions;
    public static bool allowInPassiveMode = false;
}
