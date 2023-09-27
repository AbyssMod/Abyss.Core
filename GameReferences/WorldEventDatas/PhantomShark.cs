namespace Abyss.GameReferences.WorldEventDatas;
public static class PhantomShark
{
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
    public static UnityEngine.GameObject prefab = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "PhantomShark").prefab;
    public static bool dispelByBanish = true;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 0f;
    public static float foghornDispelCount = 0f;
    public static int minWorldPhase = 2;
    public static float minSanity = 0f;
    public static float maxSanity = 0.25f;
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "PhantomShark").repeatDelay;
    public static float weight = 5f;
    public static float spawnStartTime = 0f;
    public static float spawnEndTime = 1f;
    public static bool hasDuration = false;
    public static float durationSec = 0f;
    public static bool hasMinDepth = true;
    public static float minDepth = 0.02f;
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "PhantomShark").depthTestPath;
    public static bool isPath = true;
    public static float depthPathNumChecks = 10f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(-25f, 0f, 80f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(-25f, 0f, 80f);
    public static bool doSafeZoneHitCheck = true;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(-25f, 0f, 80f);
    public static ZoneEnum forbiddenZones = ZoneEnum.DEVILS_SPINE;
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "PhantomShark").itemInventoryConditions;
    public static bool allowInPassiveMode = false;
}
