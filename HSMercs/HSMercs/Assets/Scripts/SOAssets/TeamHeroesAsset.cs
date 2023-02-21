using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "TeamHeroes", menuName = "Assets/TeamHeroes")]
   public class TeamHeroesAsset : ScriptableObject
   {
      #region VARIABLES

      //TEMP Script
      [SerializeField] private int heroCount = 4;

      #endregion

      #region PROPERTIES

      public int HeroCount => heroCount;

      #endregion

      #region METHODS



      #endregion
   }
}
