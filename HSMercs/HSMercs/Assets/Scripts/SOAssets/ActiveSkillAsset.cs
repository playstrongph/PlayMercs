using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "ActiveSkill", menuName = "Assets/SkillType/ActiveSkill")]
   public class ActiveSkillAsset : SkillTypeAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void LoadSkillTypeVisuals(ISkill skill)
      {
         //TODO: SkillReadiness Effect
         skill.SkillAttributes.SkillReadiness.LoadSkillReadinessVisuals(skill);

      }
      
      
      /// <summary>
      /// Set valid target hero for active/basic skills.  Checks skill readiness
      /// </summary>
      /// <param name="skill"></param>
      public override void SelectTarget(ISkill skill)
      {
         skill.SkillAttributes.SkillReadiness.SelectTarget(skill);
      }
      
      /// <summary>
      /// Disables the skill target visuals - node, cross hair, and arrow
      /// </summary>
      /// <param name="skill"></param>
      public override void DisableTargetVisuals(ISkill skill)
      {
         //skill.SkillTargetCollider.DrawTargetLineAndArrow.DisableTargetVisuals();
         
         skill.SkillAttributes.SkillReadiness.DisableTargetVisuals(skill);
      }
      
      public override void EnableSkillTargeting(ISkill skill)
      {
         //Temporarily hides the skill target visuals of the selected skill while selecting a new target
         skill.SkillTargetCollider.ManualSelectTarget.HideSelectedSkillTargetVisuals();
         //TEST
         skill.SkillTargetCollider.SkillTargeting.EnableSkillTargeting();
      }

      #endregion
   }
}
