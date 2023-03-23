using System.Collections.Generic;
using UnityEngine;

public interface IHeroesList
{
    List<IHero> HeroesList { get; }
    GameObject ThisGameObject { get; }
}