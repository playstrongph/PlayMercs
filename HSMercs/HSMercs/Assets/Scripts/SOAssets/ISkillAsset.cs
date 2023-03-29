using UnityEngine;

namespace SOAssets
{
    public interface ISkillAsset
    {
        string SkillName { get; }
        string SkillDescription { get; }
        Sprite SkillIcon { get; }
        int BaseCooldownCost { get; }
        int FightingSpiritCost { get; }
    }
}