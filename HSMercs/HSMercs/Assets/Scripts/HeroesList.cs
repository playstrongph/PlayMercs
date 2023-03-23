using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HeroesList : MonoBehaviour, IHeroesList
{
   #region VARIABLES
   
   //For display purposes only - not required logically
   [SerializeField] protected List<Object> aliveHeroes = new List<Object>();

   
   
   #endregion
        
   #region PROPERTIES
   //public List<IHero> ThisList { get; private set; }

   public List<IHero> AliveHeroes { get; private set; }


   #endregion
        
   #region METHODS

   private void Awake()
   {
      //ThisList = new List<IHero>();
      
      AliveHeroes = new List<IHero>();
   }

   public virtual void AddHero(IHero hero)
   {
      
   }
   
   public virtual void RemoveHero(IHero hero)
   {
      
   }


   #endregion
}
