using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "SkillReady", menuName = "Assets/SkillReadiness/SkillReady")]
   public class SkillReadyAsset : SkillReadinessAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void LoadSkillReadinessVisuals(ISkill skill)
      {
         //TODO: SKill Glow, No Cooldown Icon, No Cooldown Text

         var skillGraphics = skill.SkillVisual.SkillGraphics;

         //Enable Images
         skillGraphics.SkillReadyFrame.enabled = true;
         skillGraphics.SkillReadyGraphic.enabled = true;
         skillGraphics.SkillReadyText.enabled = true;
         
         //Disable Images
         skillGraphics.SkillNotReadyFrame.enabled = false;
         skillGraphics.SkillNotReadyGraphic.enabled = false;
         skillGraphics.SkillNotReadyText.enabled = false;
      }

      #endregion
   }
}
