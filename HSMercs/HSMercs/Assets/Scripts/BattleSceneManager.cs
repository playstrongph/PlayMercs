using System;
using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;
using Object = UnityEngine.Object;

public class BattleSceneManager : MonoBehaviour, IBattleSceneManager
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneSettingsAsset))] private Object battleSceneSettings;

   private IInitializePlayers _initializePlayers;
   
   
   
   

   #endregion

   #region PROPERTIES

   public IBattleSceneSettingsAsset BattleSceneSettings { get=>battleSceneSettings as IBattleSceneSettingsAsset; private set => battleSceneSettings = value as Object;}
   public GameObject ThisGameObject => this.gameObject;

   public IInitializeTeams InitializeTeams { get; private set; }

   public IPlayer MainPlayer { get; set; }
   public IPlayer EnemyPlayer { get; set; }

   #endregion

   #region METHODS

   private void Awake()
   {
      _initializePlayers = GetComponent<IInitializePlayers>();
      InitializeTeams = GetComponent<IInitializeTeams>();
   }

   private void Start()
   {

      StartCoroutine(StartAllCoroutines());

      //_initializePlayers.StartAction();
      //InitializeTeamHeroes.StartAction();

   }

   private IEnumerator StartAllCoroutines()
   {
      yield return StartCoroutine(InitializePlayers());
      yield return StartCoroutine(InitializeAllTeams());
      
      yield return null;
   }



   private IEnumerator InitializePlayers()
   {
      _initializePlayers.StartAction();
      yield return null;
   }
   
   private IEnumerator InitializeAllTeams()
   {
      InitializeTeams.StartAction();
      yield return null;
   }



   #endregion
}
