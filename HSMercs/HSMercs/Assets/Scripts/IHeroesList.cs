using System.Collections.Generic;
using UnityEngine;

public interface IHeroesList
{
    //List<IHero> ThisList { get; }

    List<IHero> AliveHeroes { get; }

    void AddHero(IHero hero);

    void RemoveHero(IHero hero);

}