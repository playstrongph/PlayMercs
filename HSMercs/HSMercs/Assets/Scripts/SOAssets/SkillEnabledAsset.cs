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
      }

      #endregion
   }
}
