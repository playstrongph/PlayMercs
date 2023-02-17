using UnityEngine;

namespace SOAssets
{
    public interface IBattleSceneSettingsAsset
    {
        GameObject HeroPrefab { get; }
        GameObject SkillPrefab { get; }
        GameObject SkillsPanelPrefab { get; }
        GameObject PlayerPrefab { get; }
    }
}