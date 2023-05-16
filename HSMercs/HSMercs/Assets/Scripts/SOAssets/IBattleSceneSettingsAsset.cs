using UnityEngine;

namespace SOAssets
{
    public interface IBattleSceneSettingsAsset
    {
        GameObject HeroPrefab { get; }
        //GameObject SkillPrefab { get; }
        GameObject HeroSkillsPrefab { get; }
        GameObject PlayerPrefab { get; }

        ITeamHeroesAsset AllyTeamHeroes { get; }
        ITeamHeroesAsset EnemyTeamHeroes { get; }

        GameObject GameBoardPrefab { get; }

        GameObject SkillQueuePanel { get; }
        GameObject SkillQueuePreviewPrefab { get; }


    }
}