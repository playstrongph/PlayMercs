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

   private IInitializePlayersVisual _initializePlayersVisual;
   
   
   
   

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
      _initializePlayersVisual = GetComponent<IInitializePlayersVisual>();
      InitializeTeamHeroes = GetComponent<IInitializeTeamHeroes>();
   }

   private void Start()
   {
      _initializePlayersVisual.StartAction();
      
      InitializeTeamHeroes.StartAction();

   }

   

   #endregion
}
