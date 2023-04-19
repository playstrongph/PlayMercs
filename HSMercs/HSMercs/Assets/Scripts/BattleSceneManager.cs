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

   public IInitializeTeamHeroes InitializeTeamHeroes { get; private set; }

   public IPlayer MainPlayer { get; set; }
   public IPlayer EnemyPlayer { get; set; }

   #endregion

   #region METHODS

   private void Awake()
   {
      _initializePlayers = GetComponent<IInitializePlayers>();
      InitializeTeamHeroes = GetComponent<IInitializeTeamHeroes>();
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
      yield return StartCoroutine(InitializeTeams());
      
      yield return null;
   }



   private IEnumerator InitializePlayers()
   {
      _initializePlayers.StartAction();
      yield return null;
   }
   
   private IEnumerator InitializeTeams()
   {
      InitializeTeamHeroes.StartAction();
      yield return null;
   }



   #endregion
}
