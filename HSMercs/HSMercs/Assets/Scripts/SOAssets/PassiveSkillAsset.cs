using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "PassiveSkill", menuName = "Assets/SkillType/PassiveSkill")]
   public class PassiveSkillAsset : SkillTypeAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      /// <summary>
      /// For passive skills, just display Skill Preview
      /// </summary>
      /// <param name="skill"></param>
      public override void UpdateSelectedSkillAndTarget(ISkill skill)
      {
         skill.SkillVisual.SkillPreviewVisual.ShowSkillPreview.TurnOn();
      }
      
      public override void LoadSkillTypeVisuals(ISkill skill)
      {
         var skillGraphics = skill.SkillVisual.SkillGraphics;


         
         skillGraphics.PassiveSkillFrame.enabled = true;
         skillGraphics.PassiveSkillGraphic.enabled = true;
         
         //This is the skill speed
         skillGraphics.SkillReadyText.enabled = true;
         
         
         skillGraphics.SkillReadyFrame.enabled = false;
         skillGraphics.SkillReadyGraphic.enabled = false;
         skillGraphics.SkillNotReadyFrame.enabled = false;
         skillGraphics.SkillNotReadyGraphic.enabled = false;
         skillGraphics.SkillNotReadyText.enabled = false;

      }
     

      #endregion
   }
}
