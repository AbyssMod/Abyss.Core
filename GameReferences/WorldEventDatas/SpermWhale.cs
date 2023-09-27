namespace Abyss.GameReferences.WorldEventDatas;
public static class SpermWhale
{
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
    public static UnityEngine.GameObject prefab = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "SpermWhale").prefab;
    public static bool dispelByBanish = false;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 0f;
    public static float foghornDispelCount = 0f;
    public static int minWorldPhase = 2;
    public static float minSanity = 0f;
    public static float maxSanity = 0.75f;
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "SpermWhale").repeatDelay;
    public static float weight = 200f;
    public static float spawnStartTime = 0.35f;
    public static float spawnEndTime = 0.7f;
    public static bool hasDuration = false;
    public static float durationSec = 0f;
    public static bool hasMinDepth = true;
    public static float minDepth = 0.35f;
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "SpermWhale").depthTestPath;
    public static bool isPath = false;
    public static float depthPathNumChecks = 5f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(5f, 0f, 100f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(5f, 0f, 100f);
    public static bool doSafeZoneHitCheck = true;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(5f, 0f, 100f);
    public static ZoneEnum forbiddenZones = ZoneEnum.STELLAR_BASIN;
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "SpermWhale").itemInventoryConditions;
    public static bool allowInPassiveMode = true;
}
