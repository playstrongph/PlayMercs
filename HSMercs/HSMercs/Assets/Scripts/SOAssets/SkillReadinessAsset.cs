﻿using UnityEngine;

namespace SOAssets
{
   public class SkillReadinessAsset : ScriptableObject, ISkillReadinessAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public virtual void LoadSkillReadinessVisuals(ISkill skill)
      {
         
      }
      
      /// <summary>
      /// Enable skill targeting when skill is NOT disabled and skill is ready
      /// </summary>
      /// <param name="transform"></param>
      /// <param name="skillTargetCollider"></param>
      public virtual void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider)
      {
         //var skill = skillTargetCollider.Skill;
         //skill.SkillAttributes.SkillEnableStatus.EnableTargetVisuals(transform,skillTargetCollider);

      }
      
      /// <summary>
      /// Used in verifying if skill is ready and enabled
      /// </summary>
      /// <param name="skill"></param>
      public virtual void SelectTarget(ISkill skill)
      {
         
      }
      
      public virtual void DisableTargetVisuals(ISkill skill)
      {
         
      }
      

      #endregion
   }
}
