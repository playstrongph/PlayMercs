﻿using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "SkillTargetEnemies", menuName = "Assets/SkillTarget/SkillTargetEnemies")]
   public  class SkillTargetEnemiesAsset : SkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public override List<IHero> HeroTargets(IHero hero)
      {
         return new List<IHero>(hero.Player.OtherPlayer.Heroes.HeroStatusLists.GetAliveHeroList());
      }
      
      public override void ShowHeroGlow(IHero hero)
      {
         hero.HeroVisual.HeroGraphics.RedGlow.enabled = true;
      }
      
      public override void HideHeroGlow(IHero hero)
      {
         hero.HeroVisual.HeroGraphics.RedGlow.enabled = false;
      }
      
      
        

      #endregion
   }
}
