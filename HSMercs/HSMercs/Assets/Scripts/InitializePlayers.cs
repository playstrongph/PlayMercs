using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayers : MonoBehaviour, IInitializePlayers
{
   
   #region VARIABLES

   private IBattleSceneManager _battleSceneManager;
   [SerializeField] private Vector3 alliesPosition = new Vector3(0, -90, 0);
   [SerializeField] private Vector3 enemiesPosition = new Vector3(0, 90, 0);

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
      var playerPrefab = _battleSceneManager.BattleSceneSettings.PlayerPrefab;
      var playerParentTransform = _battleSceneManager.ThisGameObject.transform;

      var mainPlayerGameObject = Instantiate(playerPrefab, playerParentTransform);
      var mainPlayer = mainPlayerGameObject.GetComponent<IPlayer>();
      mainPlayerGameObject.name = "Main Player";
      mainPlayer.BattleSceneManager = _battleSceneManager;
      
      
      mainPlayerGameObject.transform.position = alliesPosition;
      

      var enemyPlayerGameObject = Instantiate(playerPrefab, playerParentTransform);
      var enemyPlayer = enemyPlayerGameObject.GetComponent<IPlayer>();
      enemyPlayerGameObject.name = "Enemy Player";
      enemyPlayerGameObject.transform.position = enemiesPosition;
      enemyPlayer.BattleSceneManager = _battleSceneManager;
      
      //Set References
      _battleSceneManager.MainPlayer = mainPlayer;
      _battleSceneManager.EnemyPlayer = enemyPlayer;
      
      

   }


   #endregion
  
}
