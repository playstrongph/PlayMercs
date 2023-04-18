using UnityEngine;

public interface IPlayer
{
    IBattleSceneManager BattleSceneManager { get; set; }

    //IHeroesList AliveHeroes { get; }

    IInitializePlayerHeroes InitializePlayerHeroes { get; }

    IHeroes Heroes { get; }
    Transform HeroPreviewsTransform { get; }

    Transform HeroSkillsTransform { get; }


}