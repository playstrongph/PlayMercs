using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "BasicSkill", menuName = "Assets/SkillType/BasicSkill")]
   public class BasicSkillAsset : SkillTypeAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void LoadSkillTypeVisuals(ISkill skill)
      {
         skill.SkillAttributes.SkillReadiness.LoadSkillReadinessVisuals(skill);
         
         //Note: Technically speaking, basic skills are ALWAYS ACTIVE and READY
         //The status checking above is not really required
      }
      
      
      /// <summary>
      /// Sets the valid target hero
      /// </summary>
      /// <param name="skill"></param>
      public override void SetValidTargetHero(ISkill skill)
      {
         skill.SkillAttributes.SkillReadiness.SetValidTargetHero(skill);
         
         //Note: Technically speaking, basic skills are ALWAYS ACTIVE and READY 
         //The status checking above is not really required
      }
      
      public override void DisableTargetVisuals(ISkill skill)
      {
         //skill.SkillTargetCollider.DrawTargetLineAndArrow.DisableTargetVisuals();
         
         skill.SkillAttributes.SkillReadiness.DisableTargetVisuals(skill);
      }

      #endregion
   }
}
