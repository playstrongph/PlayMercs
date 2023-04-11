using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   
   /// <summary>
   /// Fighter - Green
   /// Caster - Blue
   /// Defender - Red
   /// </summary>
   [CreateAssetMenu(fileName = "FighterClass", menuName = "Assets/HeroClass/FighterClass")]
   public class FighterClassAsset : HeroClassAsset
   {
      #region VARIABLES


      #endregion
        
      #region PROPERTIES

     

      #endregion
        
      #region METHODS

      public override void SetClassColor(IHeroGraphics heroGraphics)
      {
         
         heroGraphics.GreenFrame.enabled = true;
         heroGraphics.RedFrame.enabled = false;
         heroGraphics.BlueFrame.enabled = false;

         heroGraphics.GreenHeroGraphic.enabled = true;
         heroGraphics.RedHeroGraphic.enabled = false;
         heroGraphics.BlueHeroGraphic.enabled = false;
         
         //HERO PREVIEW
         
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.GreenFrame.enabled = true;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.RedFrame.enabled = false;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.BlueFrame.enabled = false;
         
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.GreenHeroGraphic.enabled = true;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.RedHeroGraphic.enabled = false;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.BlueHeroGraphic.enabled = false;
      }


      #endregion
   }
}
