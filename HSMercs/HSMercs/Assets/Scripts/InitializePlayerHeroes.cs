using System;
using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;

public class InitializePlayerHeroes : MonoBehaviour, IInitializePlayerHeroes
{
   #region VARIABLES
   
  
   private IPlayer _player;

   #endregion
        
   #region PROPERTIES

   

   #endregion
        
   #region METHODS

   private void Awake()
   {
      _player = GetComponent<IPlayer>();
   }

   public void StartAction(ITeamHeroesAsset teamHeroesAsset, GameObject heroPrefab, Transform heroesParent)
   {

      for (int i = 0; i < teamHeroesAsset.HeroCount; i++)
      {
         //var herObject = Instantiate(heroPrefab, heroesParent);
      }   
      
      
   }
   
   public void StartAction(ITeamHeroesAsset teamHeroesAsset, GameObject heroPrefab, IHeroesList heroesList)
   {

      for (int i = 0; i < teamHeroesAsset.HeroCount; i++)
      {
         var herObject = Instantiate(heroPrefab, heroesList.ThisGameObject.transform);
         var hero = herObject.GetComponent<IHero>();
         
         heroesList.HeroesList.Add(hero);
      }   
      
      
   }


   #endregion
}
