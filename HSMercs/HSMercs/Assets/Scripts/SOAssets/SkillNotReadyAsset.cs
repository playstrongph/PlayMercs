using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "SkillNotReady", menuName = "Assets/SkillReadiness/SkillNotReady")]
   public class SkillNotReadyAsset : SkillReadinessAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void LoadSkillReadinessVisuals(ISkill skill)
      {
         var skillGraphics = skill.SkillVisual.SkillGraphics;

         //Enable Images
         skillGraphics.SkillNotReadyFrame.enabled = true;
         skillGraphics.SkillNotReadyGraphic.enabled = true;
         skillGraphics.SkillNotReadyText.enabled = true;
         
         //Disable Images
         skillGraphics.SkillReadyFrame.enabled = false;
         skillGraphics.SkillReadyGraphic.enabled = false;
         skillGraphics.SkillReadyText.enabled = false;
      }

      #endregion
   }
}
