using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   [CreateAssetMenu(fileName = "TeamHeroes", menuName = "Assets/TeamHeroes")]
   public class TeamHeroesAsset : ScriptableObject, ITeamHeroesAsset
   {
      #region VARIABLES
      
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAllianceAsset))] private ScriptableObject playerAllianceAsset = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroAsset))] private List<ScriptableObject> heroAssets = new List<ScriptableObject>();
      

      #endregion

      #region PROPERTIES

      public IPlayerAllianceAsset PlayerAllianceAsset => playerAllianceAsset as IPlayerAllianceAsset;
      
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

      #endregion

      #region METHODS



      #endregion
   }
}
