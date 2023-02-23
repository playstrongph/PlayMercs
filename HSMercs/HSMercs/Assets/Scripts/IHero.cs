using UnityEngine;

public interface IHero
{
    IHeroVisual HeroVisual { get; }

     Transform HeroTransform { get; }
}