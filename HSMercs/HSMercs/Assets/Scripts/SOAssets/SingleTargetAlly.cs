using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "SingleTargetAlly", menuName = "Assets/SkillTarget/SingleTargetAlly")]
   public  class SingleTargetAlly : SkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      /// <summary>
      /// The hero referred to here is the skill's caster hero
      /// </summary>
      /// <param name="hero"></param>
      /// <returns></returns>
      public override List<IHero> GetHeroTargets(IHero hero)
      {
         //Temporary
         return new List<IHero>(hero.Player.Heroes.HeroStatusLists.GetAliveHeroList());
      }
      
      //TODO: Resolve stealth and Taunt
      public override void ResolveSpecialTargets(IHero hero)
      {
         //Example: Stealth and Taunt
      }
      
      public override void ShowTargetsGlow(IHero hero)
      {
         hero.HeroVisual.HeroGraphics.YellowGlow.enabled = true;
      }

      public override void HideTargetsGlow(IHero hero)
      {
         hero.HeroVisual.HeroGraphics.YellowGlow.enabled = false;
      }
      

      #endregion
   }
}
