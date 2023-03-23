using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Player : MonoBehaviour, IPlayer
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroesList))] private Object aliveHeroes;

   [SerializeField] private Transform heroPreviews;
        

   #endregion
        
   #region PROPERTIES

   public IHeroesList AliveHeroes { get=> aliveHeroes as IHeroesList; private set => aliveHeroes = value as Object;}

   public IBattleSceneManager BattleSceneManager { get; set; }

   public IInitializePlayerHeroes InitializePlayerHeroes { get; private set; }

   public Transform HeroPreviews { get => heroPreviews; private set => heroPreviews = value; }


   #endregion
        
   #region METHODS

   private void Awake()
   {
      InitializePlayerHeroes = GetComponent<IInitializePlayerHeroes>();
   }

   #endregion
   
   
}
