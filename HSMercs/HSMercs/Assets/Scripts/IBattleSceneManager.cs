using SOAssets;
using UnityEngine;

public interface IBattleSceneManager
{
    IBattleSceneSettingsAsset BattleSceneSettings { get; }
    GameObject ThisGameObject { get; }
    
     IPlayer MainPlayer { get; set; }
     IPlayer EnemyPlayer { get; set; }

     IInitializeTeamHeroes InitializeTeamHeroes { get; }
}