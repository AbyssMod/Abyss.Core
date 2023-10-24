namespace Abyss.GameReferences.AchievementDatas;
public static class ENDING
{
    public static AchievementData ENDINGInstance = (AchievementData)System.Linq.Enumerable.First(ScriptableObjectInstances.AchievementDatas, x => x.name == "ENDING");
    public static DredgeAchievementId id = DredgeAchievementId.ENDING;
    public static string steamId = "";
    public static int playStationId = 8;
    public static string xboxId = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[AchievementCondition, Dredge_Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<AchievementCondition> evaluationConditions = ENDINGInstance.evaluationConditions;
}
