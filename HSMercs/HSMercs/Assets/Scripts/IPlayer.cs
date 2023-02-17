using UnityEngine;

public interface IPlayer
{
    IBattleSceneManager BattleSceneManager { get; set; }
    
    Vector3 AlliesPosition { get; }
    Vector3 EnemiesPosition { get; }
}