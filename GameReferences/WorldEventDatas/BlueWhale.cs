namespace Abyss.GameReferences.WorldEventDatas;
public static class BlueWhale
{
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
    public static UnityEngine.GameObject prefab = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "BlueWhale").prefab;
    public static bool dispelByBanish = false;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 0f;
    public static float foghornDispelCount = 0f;
    public static int minWorldPhase = 0;
    public static float minSanity = 0.75f;
    public static float maxSanity = 1f;
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "BlueWhale").repeatDelay;
    public static float weight = 15f;
    public static float spawnStartTime = 0.25f;
    public static float spawnEndTime = 0.75f;
    public static bool hasDuration = false;
    public static float durationSec = 0f;
    public static bool hasMinDepth = true;
    public static float minDepth = 0.35f;
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "BlueWhale").depthTestPath;
    public static bool isPath = true;
    public static float depthPathNumChecks = 10f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(-25f, 0f, 125f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(-25f, 0f, 125f);
    public static bool doSafeZoneHitCheck = true;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(-25f, 0f, 125f);
    public static ZoneEnum forbiddenZones = ZoneEnum.NONE;
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "BlueWhale").itemInventoryConditions;
    public static bool allowInPassiveMode = true;
}
