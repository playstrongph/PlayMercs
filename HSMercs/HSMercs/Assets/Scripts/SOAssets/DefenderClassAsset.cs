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

      public override string ClassName { get; } = "Defender";

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
         
         //HERO PREVIEW
         
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.GreenFrame.enabled = false;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.RedFrame.enabled = true;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.BlueFrame.enabled = false;
         
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.GreenHeroGraphic.enabled = false;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.RedHeroGraphic.enabled = true;
         heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.BlueHeroGraphic.enabled = false;
         
         heroGraphics.Hero.HeroSkills.ThreeSkillPanel.BluePanel.enabled = false;
         heroGraphics.Hero.HeroSkills.ThreeSkillPanel.RedPanel.enabled = true;
         heroGraphics.Hero.HeroSkills.ThreeSkillPanel.GreenPanel.enabled = false;
         
         /*heroGraphics.Hero.HeroSkills.FourSkillPanel.BluePanel.enabled = false;
         heroGraphics.Hero.HeroSkills.FourSkillPanel.RedPanel.enabled = true;
         heroGraphics.Hero.HeroSkills.FourSkillPanel.GreenPanel.enabled = false;*/
      }


      #endregion
   }
}
