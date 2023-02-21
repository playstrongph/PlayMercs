using System;
using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;

public class InitializePlayerHeroesVisual : MonoBehaviour, IInitializePlayerHeroesVisual
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
         var herObject = Instantiate(heroPrefab, heroesParent);
      }   
      
      
   }


   #endregion
}
