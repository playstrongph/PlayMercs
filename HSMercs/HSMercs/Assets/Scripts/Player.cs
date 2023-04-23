using System;
using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

public class Player : MonoBehaviour, IPlayer
{
   #region VARIABLES

   //[SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroesList))] private Object aliveHeroes;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroes))] private Object heroes;
   
   [SerializeField] private Transform heroPreviewsTransform;
   
   [SerializeField] private Transform heroSkillsTransform;
   
   [Header("SET IN RUNTIME")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAllianceAsset))] private ScriptableObject playerAllianceAsset = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkills))] private Object heroSkillsOnDisplay = null;
        

   #endregion
        
   #region PROPERTIES

   public IBattleSceneManager BattleSceneManager { get; set; }

   public IHeroes Heroes { get => heroes as IHeroes; private set => heroes = value as Object; }
   public Transform HeroPreviewsTransform { get => heroPreviewsTransform; private set => heroPreviewsTransform = value; }
   
   public Transform HeroSkillsTransform { get => heroSkillsTransform; private set => heroSkillsTransform = value; }

   public IPlayerAllianceAsset PlayerAllianceAsset { get => playerAllianceAsset as IPlayerAllianceAsset; set => playerAllianceAsset = value as ScriptableObject; }
   public IHeroSkills HeroSkillsOnDisplay { get => heroSkillsOnDisplay as IHeroSkills; set => heroSkillsOnDisplay = value as Object; }

   /// <summary>
   /// For the ally player, this is the enemy player; for the enemy player, this is the ally player
   /// </summary>
   public IPlayer OtherPlayer { get; set; }

   #endregion
        
   #region METHODS

   

   #endregion
   
   
}
