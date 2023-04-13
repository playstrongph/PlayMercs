using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
    /// <summary>
    /// Hero races - human, orc, druid, etc.
    /// </summary>
   public class HeroRaceAsset : ScriptableObject, IHeroRaceAsset
   {
      #region VARIABLES


      #endregion
        
      #region PROPERTIES

      public virtual string RaceName { get; } = "Hero Race";


      #endregion
        
      #region METHODS
        
      /// <summary>
      /// Set text of Hero Race in the hero preview
      /// </summary>
      /// <param name="hero"></param>
      public virtual void SetHeroRace(IHero hero)
      {
          
          
          hero.HeroVisual.HeroPreview.HeroGraphicPreview.PreviewRaceText.text = RaceName;
      }


      #endregion
   }
}
