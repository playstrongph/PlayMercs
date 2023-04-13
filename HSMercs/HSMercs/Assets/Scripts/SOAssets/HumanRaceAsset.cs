using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
    /// <summary>
    /// Hero races - human, orc, druid, etc.
    /// </summary>
    [CreateAssetMenu(fileName = "HumanRace", menuName = "Assets/HeroRace/HumanRace")]
   public class HumanRaceAsset : HeroRaceAsset
   {
      #region VARIABLES


      #endregion
        
      #region PROPERTIES

      public override string RaceName { get; } = "Human";


      #endregion
        
      #region METHODS


      #endregion
   }
}
