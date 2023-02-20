using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayersVisual : MonoBehaviour, IInitializePlayersVisual
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
      var playerPrefab = _battleSceneManager.BattleSceneSettings.PlayerPrefab;
      var playerParentTransform = _battleSceneManager.ThisGameObject.transform;

      var mainPlayerGameObject = Instantiate(playerPrefab, playerParentTransform);
      var mainPlayer = mainPlayerGameObject.GetComponent<IPlayer>();
      mainPlayerGameObject.name = "Main Player";
      mainPlayerGameObject.transform.position = mainPlayer.AlliesPosition;
      

      var enemyPlayerGameObject = Instantiate(playerPrefab, playerParentTransform);
      var enemyPlayer = enemyPlayerGameObject.GetComponent<IPlayer>();
      enemyPlayerGameObject.name = "Enemy Player";
      enemyPlayerGameObject.transform.position = mainPlayer.EnemiesPosition;

   }


   #endregion
  
}
