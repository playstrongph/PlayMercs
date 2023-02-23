using System.Collections.Generic;
using UnityEngine;

public interface IHeroesList
{
    IPlayer Player { get; }
    List<IHero> HeroesList { get; }
    GameObject ThisGameObject { get; }



    
}