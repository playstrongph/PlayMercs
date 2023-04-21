using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
    /// <summary>
    /// Skill elements  - Frost, Fire, Arcane, etc.
    /// </summary>
   public class SkillElementAsset : ScriptableObject, ISkillElementAsset
    {
      #region VARIABLES


      #endregion
        
      #region PROPERTIES

      public virtual string ElementName { get; } = "Skill Element";


      #endregion
        
      #region METHODS
        
      /// <summary>
      /// Set text of Hero Race in the hero preview
      /// </summary>
      /// <param name="skill"></param>
      public virtual void SetElement(ISkill skill)
      {
          
      }


      #endregion
   }
}
