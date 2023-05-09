using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "SkillEnabled", menuName = "Assets/SkillEnable/SkillEnabled")]
   public class SkillEnabledAsset : SkillEnableAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider)
      {
         //TODO: Check Skill Readiness and Skill Enabled first
        
         //Resets local position to zero
         transform.localPosition = Vector3.zero;
         
         //SkillTargetCollider.TargetArrow.SetActive(true);
         skillTargetCollider.Draggable.EnableDraggable();
         
         //Show valid Targets Skill Glow
         skillTargetCollider.SkillTargets.ShowValidTargetsGlow();
      }
      
      /// <summary>
      /// Skill should be enabled before setting the valid target hero
      /// </summary>
      /// <param name="skill"></param>
      public override void SelectTarget(ISkill skill)
      {
         skill.SkillTargetCollider.ManualSelectTarget.SelectTarget();
      }

      public override void DisableTargetVisuals(ISkill skill)
      {
         skill.SkillTargetCollider.SkillTargeting.DisableSkillTargeting();
      }
      
      /// <summary>
      /// This is the "X" icon 
      /// </summary>
      /// <param name="skill"></param>
      public override void SkillDisabledVisuals(ISkill skill)
      {
         skill.SkillVisual.SkillGraphics.SkillDisabledGraphic.enabled = false;
      }

      #endregion
   }
   
   
}
