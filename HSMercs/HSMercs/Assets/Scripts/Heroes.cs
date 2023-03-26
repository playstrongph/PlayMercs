using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroes : MonoBehaviour, IHeroes
{
   #region VARIABLES
   
   //[SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IAliveHeroes))]private Object aliveHeroes;

  
   
   #endregion

   #region PROPERTIES

   public IHeroStatusLists HeroStatusLists { get; private set; }

   /*public IAliveHeroes AliveHeroes
   {
      get => aliveHeroes as IAliveHeroes;
      private set => aliveHeroes = value as Object;
   }*/

   public Transform ThisTransform
   {
      get => transform;
      private set => value = transform;
   }

   #endregion

   #region METHODS

   private void Awake()
   {
      HeroStatusLists = GetComponent<IHeroStatusLists>();
   }

   #endregion
}
