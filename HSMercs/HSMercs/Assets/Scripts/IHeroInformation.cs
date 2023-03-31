using UnityEngine;

public interface IHeroInformation
{
    string HeroName { get; }
    string HeroClass { get; }
    Sprite HeroSprite { get; }
    int HeroLevel { get; }
    int HeroStars { get; }
    int HeroCp { get; }
}