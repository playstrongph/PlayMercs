using UnityEngine;

namespace SOAssets
{
    public interface ISkillAsset
    {
        string SkillName { get; }
        string SkillDescription { get; }
        Sprite SkillIcon { get; }
        int SkillCooldown { get; }
        int FightingSpirit { get; }
        int SkillSpeed { get; }
        ISkillElementAsset SkillElement { get; }

    }
}