using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   
   /// <summary>
   /// Fighter - Green
   /// Caster - Blue
   /// Defender - Red
   /// </summary>
   [CreateAssetMenu(fileName = "CasterClass", menuName = "Assets/HeroClass/CasterClass")]
   public class CasterClassAsset : HeroClassAsset
   {
      #region VARIABLES


      #endregion
        
      #region PROPERTIES

      public override string ClassName { get; } = "Caster";

      #endregion
        
      #region METHODS

      public override void SetClassColor(IHeroGraphics heroGraphics)
      {
         
         heroGraphics.GreenFrame.enabled = false;
         heroGraphics.RedFrame.enabled = false;
         heroGraphics.BlueFrame.enabled = true;

         heroGraphics.GreenHeroGraphic.enabled = false;
         heroGraphics.RedHeroGraphic.enabled = false;
         heroGraphics.BlueHeroGraphic.enabled = true;
         
         //HERO PREVIEW
         
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.GreenFrame.enabled = false;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.RedFrame.enabled = false;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.BlueFrame.enabled = true;
         
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.GreenHeroGraphic.enabled = false;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.RedHeroGraphic.enabled = false;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.BlueHeroGraphic.enabled = true;
      }


      #endregion
   }
}
