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

   private IInitializeSkillsQueuePreview _initializeSkillsQueuePreview;
   
   

   public IPlayer MainPlayer { get; set; }
   public IPlayer EnemyPlayer { get; set; }

   public IGameBoard GameBoard { get; private set; }

   public ISkillQueue SkillQueue { get; private set; }

   public ISkillQueuePreview SkillQueuePreview { get; set; }



   #endregion

   #region METHODS

   private void Awake()
   {
      _initializePlayers = GetComponent<IInitializePlayers>();
      _initializeHeroes = GetComponent<IInitializeHeroes>();
      _initializeSkills = GetComponent<IInitializeSkills>();
      _initializeSkillsQueuePreview = GetComponent<IInitializeSkillsQueuePreview>();
      
      
      SkillQueue = GetComponent<ISkillQueue>();
   }

   private void Start()
   {
      StartCoroutine(StartAllCoroutines());
   }

   private IEnumerator StartAllCoroutines()
   {
      
      
      yield return StartCoroutine(InitializeGameBoard());
      
      yield return StartCoroutine(InitializeAllPlayers());
      
      yield return StartCoroutine(InitializeAllHeroes());

      yield return StartCoroutine(InitializeAllSkills());
      
      yield return StartCoroutine(InitializeSkillQueuePreview());
      
      //TEST
      yield return StartCoroutine(StartBattle());
      
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

      //Can be placed in initialize all players but is safer here
      MainPlayer.PlayerAllianceAsset = allyHeroesAsset.PlayerAllianceAsset;
      EnemyPlayer.PlayerAllianceAsset = enemyHeroesAsset.PlayerAllianceAsset;
      
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

   private IEnumerator InitializeGameBoard()
   {
      var gameBoardPrefab = BattleSceneSettings.GameBoardPrefab;
      var gameBoardObject = Instantiate(gameBoardPrefab, this.transform);
      var gameBoard = gameBoardObject.GetComponent<IGameBoard>();

      gameBoardObject.name = gameBoard.BoardName;
      
      //Set Reference
      GameBoard = gameBoard;
      
      yield return null;
   }

   private IEnumerator InitializeSkillQueuePreview()
   {
      _initializeSkillsQueuePreview.StartAction(BattleSceneSettings.SkillQueuePreviewPrefab,this);
      
      yield return null;
   }
   
   //Temporary
   //TODO: Create its own class
   private IEnumerator StartBattle()
   {
      
      var allyHeroList = MainPlayer.Heroes.HeroStatusLists.GetAliveHeroList();
      var invertedAllyHeroList = new List<IHero>(allyHeroList);
      
      //List is inverted so that the order of displaying heroes will be towards the "RIGHT" direction
      invertedAllyHeroList.Reverse();
      
      //This is the closest hero to the "RIGHT" of the hero with a skill selected
      IHero nextHero = null;
      
      foreach (var hero in invertedAllyHeroList)
      {
         var selectedSkill = hero.HeroSkills.SelectedSkill;
         if (selectedSkill == null)
         {
            nextHero = hero;
         }
      }
      
      //If there's a next hero, trigger the "OnMouseDown" actions
      nextHero?.HeroTargetCollider.SelectHeroActions();
      yield return null;
   }
   
   



   #endregion
}
