using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class HeroStatusLists : MonoBehaviour, IHeroStatusLists
{
   #region VARIABLES
   
   //For inspector display purposes only - not required logically
   [SerializeField] protected List<Object> aliveHeroes = new List<Object>();
   
   //For inspector display purposes only - not required logically
   [SerializeField] protected List<Object> deadHeroes = new List<Object>();
   
   //For inspector display purposes only - not required logically
   [SerializeField] protected List<Object> extinctHeroes = new List<Object>();
   

   #endregion

   #region PROPERTIES

   
   private List<IHero> AliveHeroesList { get;  set; }
   
   private List<IHero> DeadHeroesList { get;  set; }
   
   private List<IHero> ExtinctHeroesList { get;  set; }
   
   
   #endregion

   #region METHODS

   private void Awake()
   {
      AliveHeroesList = new List<IHero>();
      DeadHeroesList = new List<IHero>();
      ExtinctHeroesList = new List<IHero>();
   }

   public void AddToAliveHeroList(IHero hero)
   {
      AliveHeroesList.Add(hero);
      
      aliveHeroes.Add(hero as Object);
   }
   
   public void RemoveFromAliveHeroList(IHero hero)
   {
      AliveHeroesList.Remove(hero);

      aliveHeroes.Remove(hero as Object);

   }

   public List<IHero> GetAliveHeroList()
   {
      return AliveHeroesList;
   }
   
   public void AddToDeadHeroList(IHero hero)
   {
      DeadHeroesList.Add(hero);
      
      deadHeroes.Add(hero as Object);
   }
   
   public void RemoveFromDeadHeroList(IHero hero)
   {
      DeadHeroesList.Remove(hero);

      deadHeroes.Remove(hero as Object);

   }

   public List<IHero> GetDeadHeroList()
   {
      return DeadHeroesList;
   }
   
   
   
   
   
   public void AddToExtinctHeroList(IHero hero)
   {
      ExtinctHeroesList.Add(hero);
      
      extinctHeroes.Add(hero as Object);
   }
   
   public void RemoveFromExtinctHeroList(IHero hero)
   {
      ExtinctHeroesList.Remove(hero);

      extinctHeroes.Remove(hero as Object);

   }

   public List<IHero> GetExtinctHeroList()
   {
      return ExtinctHeroesList;
   }



   #endregion

   #region TEST

   

   #endregion
}
