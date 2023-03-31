using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeTeamHeroes : MonoBehaviour, IInitializeTeamHeroes
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
      var allyHeroes = _battleSceneManager.MainPlayer.Heroes;
      var enemyHeroes = _battleSceneManager.EnemyPlayer.Heroes;

      _battleSceneManager.MainPlayer.InitializePlayerHeroes.StartAction(allyHeroesAsset,heroPrefab,allyHeroes);
      
     _battleSceneManager.EnemyPlayer.InitializePlayerHeroes.StartAction(enemyHeroesAsset,heroPrefab,enemyHeroes);

   }


   #endregion
}
