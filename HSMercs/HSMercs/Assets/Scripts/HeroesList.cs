using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HeroesList : MonoBehaviour
{
   #region VARIABLES
   
   //For display purposes only - not required logically
   [SerializeField] protected List<Object> aliveHeroes = new List<Object>();

   
   
   #endregion
        
   #region PROPERTIES
   //public List<IHero> ThisList { get; private set; }

   public List<IHero> AliveHeroesList { get; private set; }


   #endregion
        
   #region METHODS

   private void Awake()
   {
      //ThisList = new List<IHero>();
      
      AliveHeroesList = new List<IHero>();
   }


   #endregion
}
