using UnityEngine;

namespace SOAssets
{
   public class SkillEnableAsset : ScriptableObject, ISkillEnableAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public virtual void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider)
      {
         
        
      }
      
      
      /// <summary>
      /// Verification that skill is enabled before setting the valid target hero
      /// after mouse up in manual/auto select target scripts
      /// </summary>
      /// <param name="skill"></param>
      public virtual void SetValidTargetHero(ISkill skill)
      {
         
      }

      public virtual void DisableTargetVisuals(ISkill skill)
      {
         
      }



      #endregion
   }
}
