using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
    public interface IHeroAsset
    {
        string HeroName { get; }
        IHeroClassAsset HeroClass { get; }
        int HeroLevel { get; }
        int HeroStars { get; }
        int HeroCp { get; }
        Sprite HeroSprite { get; }
        int Health { get; }
        int Attack { get; }
        int Defense { get; }
        int Speed { get; }
        int Armor { get; }
        int FocusPoints { get; }
        int CriticalHitChance { get; }
        int CriticalHitDamage { get; }
        int Effectiveness { get; }
        int EffectResistance { get; }
        int DualAttackChance { get; }
        int HitChance { get; }

        List<ISkillAsset> SkillAssets { get; }
    }
}