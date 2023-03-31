using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "TeamHeroes", menuName = "Assets/TeamHeroes")]
   public class TeamHeroesAsset : ScriptableObject, ITeamHeroesAsset
   {
      #region VARIABLES

      //TEMP Script
      [SerializeField] private int heroCount = 4;

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroAsset))] private List<ScriptableObject> heroAssets = new List<ScriptableObject>();

      #endregion

      #region PROPERTIES

      public List<IHeroAsset> HeroAssets
      {
         get
         {
            var iHeroAssetList = new List<IHeroAsset>();
            foreach (var iHeroAsset in heroAssets)
            {
               iHeroAssetList.Add(iHeroAsset as IHeroAsset);  
            }
            return iHeroAssetList;
         }
      }

      public int HeroCount => heroCount;

      #endregion

      #region METHODS



      #endregion
   }
}
