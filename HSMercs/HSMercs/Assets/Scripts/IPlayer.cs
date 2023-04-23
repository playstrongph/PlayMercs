using SOAssets;
using UnityEngine;

public interface IPlayer
{
    IBattleSceneManager BattleSceneManager { get; set; }

    IHeroes Heroes { get; }
    Transform HeroPreviewsTransform { get; }

    Transform HeroSkillsTransform { get; }

    IPlayerAllianceAsset PlayerAllianceAsset { get; set; }

    IHeroSkills HeroSkillsOnDisplay { get; set; }


}