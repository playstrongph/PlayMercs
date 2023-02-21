using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeTeamHeroesVisual : MonoBehaviour
{
   #region VARIABLES

   private IBattleSceneManager _battleSceneManager;

   #endregion
        
   #region PROPERTIES

        

   #endregion
        
   #region METHODS
   
   private void Awake()
   {
      _battleSceneManager = GetComponent<IBattleSceneManager>();
   }

   public void StartAction()
   {
      var heroPrefab = _battleSceneManager.BattleSceneSettings.HeroPrefab;

      var allyHeroesAsset = _battleSceneManager.BattleSceneSettings.AllyTeamHeroes;
      var enemyHeroesAsset = _battleSceneManager.BattleSceneSettings.EnemyTeamHeroes;

      

   }


   #endregion
}
