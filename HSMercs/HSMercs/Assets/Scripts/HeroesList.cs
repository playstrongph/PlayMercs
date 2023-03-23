using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesList : MonoBehaviour, IHeroesList
{
   #region VARIABLES

   [SerializeField] private List<Object> aliveHeroes = new List<Object>();

   #endregion
        
   #region PROPERTIES
   public List<IHero> ThisList { get; private set; }

   public List<IHero> AliveHeroes
   {
      get
      {
         var getHeroes = new List<IHero>();
         foreach (var aliveHero in aliveHeroes)
         {
            getHeroes.Add(aliveHero as IHero);
         }
         return getHeroes;
      }

      set
      {
         
      }
   }


   #endregion
        
   #region METHODS

   private void Awake()
   {
      ThisList = new List<IHero>();
   }    
   
   

   #endregion
}
