using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   public abstract class SkillTargetAsset : ScriptableObject, ISkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public virtual List<IHero> HeroTargets(IHero hero)
      {
         //Ally heroes
         //All Other ally heroes
         //enemy heroes
         //None (empty list)

         return new List<IHero>();
      }
      
      public virtual void ShowHeroGlow(IHero hero)
      {
         //Ally Glow
         //Enemy Glow
         //No Glow
      }
      
      public virtual void HideHeroGlow(IHero hero)
      {
         //Ally Glow
         //Enemy Glow
         //No Glow
      }
      
      
        

      #endregion
   }
}
