using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class AliveHeroes : HeroesList
{
   #region VARIABLES

   

   #endregion

   #region PROPERTIES

   

   #endregion

   #region METHODS

   public override void AddHero(IHero hero)
   {
      AliveHeroes.Add(hero);
      
      aliveHeroes.Add(hero as Object);
   }
   
   public override void RemoveHero(IHero hero)
   {
      AliveHeroes.Remove(hero);

      aliveHeroes.Remove(hero as Object);

   }

   #endregion

   #region TEST

   

   #endregion
}
