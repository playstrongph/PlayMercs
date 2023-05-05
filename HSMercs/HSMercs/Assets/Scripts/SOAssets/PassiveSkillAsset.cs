using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "PassiveSkill", menuName = "Assets/SkillType/PassiveSkill")]
   public class PassiveSkillAsset : SkillTypeAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      /// <summary>
      /// For passive skills, just display Skill Preview
      /// </summary>
      /// <param name="skill"></param>
      public override void UpdateSelectedSkillAndTarget(ISkill skill)
      {
         skill.SkillVisual.SkillPreviewVisual.ShowSkillPreview.TurnOn();
      }
     

      #endregion
   }
}
