using UnityEngine;

public interface IGameBoard
{
    BoxCollider BoardCollider { get; }
    GameObject ThisGameObject { get; }

    string BoardName { get; }
    
    IPlayer AllyPlayer { get; set; }
    
    IPlayer EnemyPlayer { get; set; }
}