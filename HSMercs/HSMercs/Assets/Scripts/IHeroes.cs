using UnityEngine;

public interface IHeroes
{
    //IAliveHeroes AliveHeroes { get; }

    IHeroStatusLists HeroStatusLists { get; }

    Transform ThisTransform { get; }
}