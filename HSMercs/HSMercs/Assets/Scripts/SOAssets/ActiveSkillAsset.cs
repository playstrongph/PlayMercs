﻿using UnityEngine;

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
      public override void SetValidTargetHero(ISkill skill)
      {
         skill.SkillAttributes.SkillReadiness.SetValidTargetHero(skill);
      }

      #endregion
   }
}
