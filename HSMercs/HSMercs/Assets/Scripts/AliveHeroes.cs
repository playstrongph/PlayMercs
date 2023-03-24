using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class AliveHeroes : HeroesList, IAliveHeroes
{
   #region VARIABLES

   

   #endregion

   #region PROPERTIES

   

   #endregion

   #region METHODS

   public void AddHero(IHero hero)
   {
      AliveHeroesList.Add(hero);
      
      aliveHeroes.Add(hero as Object);
   }
   
   public void RemoveHero(IHero hero)
   {
      AliveHeroesList.Remove(hero);

      aliveHeroes.Remove(hero as Object);

   }

   #endregion

   #region TEST

   

   #endregion
}
