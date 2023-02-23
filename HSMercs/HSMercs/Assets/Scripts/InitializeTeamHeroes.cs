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

      var allyHeroesParent = _battleSceneManager.MainPlayer.AliveHeroes.ThisGameObject.transform;
      var enemyHeroesParent = _battleSceneManager.EnemyPlayer.AliveHeroes.ThisGameObject.transform;
      
      var allyHeroesList = _battleSceneManager.MainPlayer.AliveHeroes;
      var enemyHeroesList = _battleSceneManager.EnemyPlayer.AliveHeroes;
      
     //_battleSceneManager.MainPlayer.InitializePlayerHeroes.StartAction(allyHeroesAsset,heroPrefab,allyHeroesParent);
     //_battleSceneManager.EnemyPlayer.InitializePlayerHeroes.StartAction(enemyHeroesAsset,heroPrefab,enemyHeroesParent);
     
     _battleSceneManager.MainPlayer.InitializePlayerHeroes.StartAction(allyHeroesAsset,heroPrefab,allyHeroesList);
     _battleSceneManager.EnemyPlayer.InitializePlayerHeroes.StartAction(enemyHeroesAsset,heroPrefab,enemyHeroesList);

   }


   #endregion
}
