namespace Abyss.GameReferences.WorldEventDatas;
public static class MonsterRayAttack1
{
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
    public static UnityEngine.GameObject prefab = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "MonsterRayAttack1").prefab;
    public static bool dispelByBanish = true;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 0f;
    public static float foghornDispelCount = 0f;
    public static int minWorldPhase = 2;
    public static float minSanity = 0f;
    public static float maxSanity = 0.5f;
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "MonsterRayAttack1").repeatDelay;
    public static float weight = 3f;
    public static float spawnStartTime = 0f;
    public static float spawnEndTime = 1f;
    public static bool hasDuration = false;
    public static float durationSec = 0f;
    public static bool hasMinDepth = true;
    public static float minDepth = 0.05f;
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "MonsterRayAttack1").depthTestPath;
    public static bool isPath = true;
    public static float depthPathNumChecks = 10f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(25f, 0f, 25f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(25f, 0f, 25f);
    public static bool doSafeZoneHitCheck = true;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(25f, 0f, 25f);
    public static ZoneEnum forbiddenZones = ZoneEnum.TWISTED_STRAND, DEVILS_SPINE;
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "MonsterRayAttack1").itemInventoryConditions;
    public static bool allowInPassiveMode = false;
}
