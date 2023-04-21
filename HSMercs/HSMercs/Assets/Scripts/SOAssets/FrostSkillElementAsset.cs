using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
    /// <summary>
    /// Skill elements  - Frost, Fire, Arcane, etc.
    /// </summary>
   [CreateAssetMenu(fileName = "FrostElement", menuName = "Assets/SkillElement/FrostElement")]
   public class FrostSkillElementAsset : SkillElementAsset
    {
      #region VARIABLES


      #endregion
        
      #region PROPERTIES

      public override string ElementName { get; } = "Frost";


      #endregion
        
      #region METHODS
        
      /// <summary>
      /// Set text of Skill Element in the skill preview
      /// </summary>
      /// <param name="skill"></param>
      public override void SetElement(ISkill skill)
      {
          
      }


      #endregion
   }
}
