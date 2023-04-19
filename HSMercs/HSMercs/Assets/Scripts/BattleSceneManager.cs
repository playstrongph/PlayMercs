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


   #endregion

   #region PROPERTIES

   public IBattleSceneSettingsAsset BattleSceneSettings { get=>battleSceneSettings as IBattleSceneSettingsAsset; private set => battleSceneSettings = value as Object;}
   public GameObject ThisGameObject => this.gameObject;
   public IInitializeHeroes InitializeHeroes { get; private set; }
   
   public IInitializePlayers InitializePlayers { get; private set; }

   public IPlayer MainPlayer { get; set; }
   public IPlayer EnemyPlayer { get; set; }
   


   #endregion

   #region METHODS

   private void Awake()
   {
      InitializePlayers = GetComponent<IInitializePlayers>();
      InitializeHeroes = GetComponent<IInitializeHeroes>();
   }

   private void Start()
   {

      StartCoroutine(StartAllCoroutines());

      //_initializePlayers.StartAction();
      //InitializeTeamHeroes.StartAction();

   }

   private IEnumerator StartAllCoroutines()
   {
      yield return StartCoroutine(InitializeAllPlayers());
      
      //yield return StartCoroutine(InitializeAllTeams());
      
      yield return StartCoroutine(InitializeAllHeroes());
      
      yield return null;
   }



   private IEnumerator InitializeAllPlayers()
   {
      InitializePlayers.StartAction();
      yield return null;
   }

   private IEnumerator InitializeAllHeroes()
   {
      var heroPrefab = BattleSceneSettings.HeroPrefab;
      var allyHeroesAsset = BattleSceneSettings.AllyTeamHeroes;
      var enemyHeroesAsset = BattleSceneSettings.EnemyTeamHeroes;
      var allyHeroes = MainPlayer.Heroes;
      var enemyHeroes = EnemyPlayer.Heroes;
      var mainPlayer = MainPlayer;
      var enemyPlayer = EnemyPlayer;
      
      InitializeHeroes.StartAction(allyHeroesAsset,heroPrefab,allyHeroes,mainPlayer);
      InitializeHeroes.StartAction(enemyHeroesAsset,heroPrefab,enemyHeroes,enemyPlayer);
      
      yield return null;
   }



   #endregion
}
