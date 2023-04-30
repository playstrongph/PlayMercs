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
      
      public virtual List<IHero> GetHeroTargets(IHero hero)
      {
         //Ally heroes
         //All Other ally heroes
         //enemy heroes
         //None (empty list)

         return new List<IHero>();
      }
      
      /// <summary>
      /// Glow color is dependent on enemy type: Ally or Enemy
      /// </summary>
      public virtual void ShowTargetsGlow(IHero hero)
      {
         
      }
      
      /// <summary>
      /// Glow to be hidden is dependent on glow color that was shown
      /// </summary>
      public virtual void HideTargetsGlow(IHero hero)
      {
         
      }

      /// <summary>
      /// Resolve special circumstances in targeting
      /// </summary>
      /// <param name="hero"></param>
      public virtual void ResolveSpecialTargets(IHero hero)
      {
         //Example: Stealth and Taunt
      }

      #endregion
   }
}
