using System.Collections.Generic;

public interface IHeroStatusLists
{
    void AddToAliveHeroList(IHero hero);
    void AddToDeadHeroList(IHero hero);
    void AddToExtinctHeroList(IHero hero);

    
    void RemoveFromAliveHeroList(IHero hero);
    void RemoveFromDeadHeroList(IHero hero);
    void RemoveFromExtinctHeroList(IHero hero);
    

    List<IHero> GetAliveHeroList();
    List<IHero> GetDeadHeroList();
    List<IHero> GetExtinctHeroList();














    /*List<IHero> AliveHeroesList { get; }

    List<IHero> DeadHeroesList { get; }
    
    List<IHero> ExtinctHeroesList { get; }*/
}