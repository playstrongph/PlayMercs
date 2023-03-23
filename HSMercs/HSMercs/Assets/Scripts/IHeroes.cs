using UnityEngine;

public interface IHeroes
{
    IHeroesList AliveHeroes { get; }

    Transform ThisTransform { get; }
}