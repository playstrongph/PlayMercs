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
   
   private IInitializeHeroes _initializeHeroes;

   private IInitializePlayers _initializePlayers;

   private IInitializeSkills _initializeSkills;

   public IPlayer MainPlayer { get; set; }
   public IPlayer EnemyPlayer { get; set; }
   


   #endregion

   #region METHODS

   private void Awake()
   {
      _initializePlayers = GetComponent<IInitializePlayers>();
      _initializeHeroes = GetComponent<IInitializeHeroes>();
      _initializeSkills = GetComponent<IInitializeSkills>();
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
      
      yield return StartCoroutine(InitializeAllHeroes());

      yield return StartCoroutine(InitializeAllSkills());
      
      yield return null;
   }



   private IEnumerator InitializeAllPlayers()
   {
      _initializePlayers.StartAction();
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
      
      _initializeHeroes.StartAction(allyHeroesAsset,heroPrefab,allyHeroes,mainPlayer);
      _initializeHeroes.StartAction(enemyHeroesAsset,heroPrefab,enemyHeroes,enemyPlayer);
      
      yield return null;
   }

   private IEnumerator InitializeAllSkills()
   {
      var allyHeroes = MainPlayer.Heroes;
      var enemyHeroes = EnemyPlayer.Heroes;
      

      foreach (var enemyHero in enemyHeroes.HeroStatusLists.GetAliveHeroList())
      {
         _initializeSkills.StartAction(enemyHero, EnemyPlayer);
      }

      foreach (var allyHero in allyHeroes.HeroStatusLists.GetAliveHeroList())
      {
         _initializeSkills.StartAction(allyHero,MainPlayer);
      }
      
      yield return null;
   }



   #endregion
}
