using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   
   /// <summary>
   /// Fighter - Green
   /// Caster - Blue
   /// Defender - Red
   /// </summary>
   [CreateAssetMenu(fileName = "DefenderClass", menuName = "Assets/HeroClass/DefenderClass")]
   public class DefenderClassAsset : HeroClassAsset
   {
      #region VARIABLES


      #endregion
        
      #region PROPERTIES

     

      #endregion
        
      #region METHODS

      public override void SetClassColor(IHeroGraphics heroGraphics)
      {
         
         heroGraphics.GreenFrame.enabled = false;
         heroGraphics.RedFrame.enabled = true;
         heroGraphics.BlueFrame.enabled = false;

         heroGraphics.GreenHeroGraphic.enabled = false;
         heroGraphics.RedHeroGraphic.enabled = true;
         heroGraphics.BlueHeroGraphic.enabled = false;
      }


      #endregion
   }
}
