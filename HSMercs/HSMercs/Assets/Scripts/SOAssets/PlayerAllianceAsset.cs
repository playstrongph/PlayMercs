using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   
   
   public class PlayerAllianceAsset : ScriptableObject, IPlayerAllianceAsset
   {
      
      

      public virtual void UpdateHeroSkillsOnDisplay(IHeroSkills heroSkills, IPlayer player)
      {
         // 1) Disable the current hero skills on display
         // 2) Replace the current hero skills on display
         // 3) Enable the current hero skills on display
         // Note: Only for Ally player and its heroes.  No skill panel display for enemy player and ally heroes
      }
      
      /// <summary>
      /// Scales up the selected hero if the hero is an "Ally" hero
      /// </summary>
      /// <param name="hero"></param>
      public virtual void ScaleUpSelectedHero(IHero hero)
      {
         /*
         //Logic below is for ally heroes only 
         var newScale = new Vector3(1.5f, 1.5f, 1f);
         hero.HeroTransform.localScale = newScale;
         */
      }




   }
}
