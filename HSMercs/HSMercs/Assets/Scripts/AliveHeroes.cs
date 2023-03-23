using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class AliveHeroes : MonoBehaviour, IHeroesList
{
   #region VARIABLES

   
   #endregion

   #region PROPERTIES

   
   public List<IHero> HeroesList { get; private set; }

   public GameObject ThisGameObject => this.gameObject;


   #endregion

   #region METHODS

   private void Awake()
   {
      HeroesList = new List<IHero>();
   }

   #endregion

   #region TEST



   #endregion
}
