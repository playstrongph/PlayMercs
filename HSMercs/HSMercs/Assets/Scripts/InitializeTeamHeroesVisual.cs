using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeTeamHeroesVisual : MonoBehaviour, IInitializeTeamHeroesVisual
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

      var allyHeroesParent = _battleSceneManager.MainPlayer.AliveHeroes.ThisGameObject.transform;
      
      var enemyHeroesParent = _battleSceneManager.EnemyPlayer.AliveHeroes.ThisGameObject.transform;
      
     _battleSceneManager.MainPlayer.InitializePlayerHeroesVisual.StartAction(allyHeroesAsset,heroPrefab,allyHeroesParent);
     
     _battleSceneManager.EnemyPlayer.InitializePlayerHeroesVisual.StartAction(enemyHeroesAsset,heroPrefab,enemyHeroesParent);

   }


   #endregion
}
