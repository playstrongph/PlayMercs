using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Player : MonoBehaviour, IPlayer
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroesList))] private Object aliveHeroes;
  
        

   #endregion
        
   #region PROPERTIES

   public IHeroesList AliveHeroes { get=> aliveHeroes as IHeroesList; private set => aliveHeroes = value as Object;}

   public IBattleSceneManager BattleSceneManager { get; set; }

   public IInitializePlayerHeroesVisual InitializePlayerHeroesVisual { get; private set; }


   #endregion
        
   #region METHODS

   private void Awake()
   {
      InitializePlayerHeroesVisual = GetComponent<IInitializePlayerHeroesVisual>();
   }

   #endregion
   
   
}
