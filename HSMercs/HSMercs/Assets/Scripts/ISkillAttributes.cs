using SOAssets;
using UnityEngine;

public interface ISkillAttributes
{
    string SkillName { get; }
    string Description { get; }
    int SkillCooldown { get; set; }
    int SkillSpeed { get; set; }
    int BaseSkillCooldown { get; set; }
    int BaseSkillSpeed { get; set; }
    Sprite SkillSprite { get; set; }
    ISkillElementAsset SkillElement { get; set; }
}