namespace Abyss.GameReferences.WorldEventDatas;
public static class Waterspout
{
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
    public static UnityEngine.GameObject prefab = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Waterspout").prefab;
    public static bool dispelByBanish = false;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 0f;
    public static float foghornDispelCount = 0f;
    public static int minWorldPhase = 0;
    public static float minSanity = 0.25f;
    public static float maxSanity = 0.75f;
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Waterspout").repeatDelay;
    public static float weight = 5f;
    public static float spawnStartTime = 0f;
    public static float spawnEndTime = 1f;
    public static bool hasDuration = true;
    public static float durationSec = 25f;
    public static bool hasMinDepth = true;
    public static float minDepth = 0.01f;
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Waterspout").depthTestPath;
    public static bool isPath = false;
    public static float depthPathNumChecks = 1f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(70f, 0f, 50f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(70f, 0f, 50f);
    public static bool doSafeZoneHitCheck = true;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(70f, 0f, 50f);
    public static ZoneEnum forbiddenZones = ZoneEnum.GALE_CLIFFS, TWISTED_STRAND;
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = System.Linq.Enumerable.FirstOrDefault(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Waterspout").itemInventoryConditions;
    public static bool allowInPassiveMode = true;
}
