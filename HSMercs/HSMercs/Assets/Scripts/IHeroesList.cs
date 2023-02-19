using System.Collections.Generic;
using UnityEngine;

public interface IHeroesList
{
    IPlayer Player { get; }
    List<IHero> HeroesList { get; }
    List<GameObject> HeroesListGameObjects { get; }
    GameObject ThisGameObject { get; }
}