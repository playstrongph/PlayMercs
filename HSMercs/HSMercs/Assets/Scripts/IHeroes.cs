using UnityEngine;

public interface IHeroes
{
    //IAliveHeroes AliveHeroes { get; }

    IAliveHeroes AliveHeroes { get; }

    Transform ThisTransform { get; }
}