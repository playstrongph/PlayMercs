using UnityEngine;

public interface IPlayer
{
    IBattleSceneManager BattleSceneManager { get; set; }

    IHeroesList AliveHeroes { get; }

    IInitializePlayerHeroes InitializePlayerHeroes { get; }

    Transform HeroPreviews { get; }


}