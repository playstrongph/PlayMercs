using UnityEngine;

public interface IHeroInformation
{
    string HeroName { get; set; }
    string HeroClass { get; set; }
    Sprite HeroSprite { get; set; }
    int HeroLevel { get; set; }
    int HeroStars { get; set; }
    int HeroCp { get; set; }
}