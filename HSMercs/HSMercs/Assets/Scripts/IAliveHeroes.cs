using System.Collections.Generic;

public interface IAliveHeroes
{
    void AddHero(IHero hero);

    void RemoveHero(IHero hero);

    List<IHero> AliveHeroesList { get; }
}