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
      
      /// <summary>
      /// Enable skill targeting when skill is NOT disabled and skill is ready
      /// </summary>
      /// <param name="transform"></param>
      /// <param name="skillTargetCollider"></param>
      public override void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider)
      {
         var skill = skillTargetCollider.Skill;
         
         skill.SkillAttributes.SkillEnableStatus.EnableTargetVisuals(transform,skillTargetCollider);
      }
      
      
      /// <summary>
      /// Skill should be ready and enabled before setting the target valid hero
      /// </summary>
      /// <param name="skill"></param>
      public override void SetValidTargetHero(ISkill skill)
      {
         //Check if skill is enabled
         skill.SkillAttributes.SkillEnableStatus.SetValidTargetHero(skill);
      }

      #endregion
   }
}
