using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "SkillDisabled", menuName = "Assets/SkillEnable/SkillDisabled")]
   public class SkillDisabledAsset : SkillEnableAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider)
      {
         
      }
      
      /// <summary>
      /// This is the "X" icon 
      /// </summary>
      /// <param name="skill"></param>
      public override void SkillDisabledVisuals(ISkill skill)
      {
         skill.SkillVisual.SkillGraphics.SkillDisabledGraphic.enabled = true;
      }

      #endregion
   }
}
