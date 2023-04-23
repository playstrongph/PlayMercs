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
      }
      
      public override void SetSkillPanelClassColor(IHero hero)
      {
         hero.HeroSkills.ThreeSkillPanel.BluePanel.enabled = false;
         hero.HeroSkills.ThreeSkillPanel.RedPanel.enabled = true;
         hero.HeroSkills.ThreeSkillPanel.GreenPanel.enabled = false;
         
         hero.HeroSkills.FourSkillPanel.BluePanel.enabled = false;
         hero.HeroSkills.FourSkillPanel.RedPanel.enabled = true;
         hero.HeroSkills.FourSkillPanel.GreenPanel.enabled = false;
      }
      
      public override void SetSkillPreviewFrameColor(ISkill skill)
      {
         var skillPreviewVisual = skill.SkillVisual.SkillPreviewVisual;
         
         skillPreviewVisual.BlueFrame.enabled = false;
         skillPreviewVisual.RedFrame.enabled = true;
         skillPreviewVisual.GreenFrame.enabled = false;
      }
      
      public override void SetHeroSkillPreviewColors(IHeroSkillPreview heroSkillPreview)
      {
         heroSkillPreview.BlueFrame.enabled = false;
         heroSkillPreview.RedFrame.enabled = true;
         heroSkillPreview.GreenFrame.enabled = false;
      }
      


      #endregion
   }
}
