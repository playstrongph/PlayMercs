﻿using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;

public class HeroInformation : MonoBehaviour, IHeroInformation
{
   #region VARIABLES
   
   
   [Header("HERO INFORMATION")]
   [Header("Set in Runtime")]
   
   [SerializeField] private string heroName;
   
   [SerializeField] private int heroLevel;
   [SerializeField] private int heroStars;
   [SerializeField] private int heroCp;
   [SerializeField] private Sprite heroSprite;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroClassAsset))] private ScriptableObject heroClass = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroRaceAsset))] private ScriptableObject heroRace = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroAsset))] private ScriptableObject heroAsset = null;

   #endregion
        
   #region PROPERTIES
   
   //HERO INFORMATION
   public string HeroName { get => heroName; set => heroName = value; }
   public Sprite HeroSprite { get => heroSprite; set => heroSprite = value; }
   public int HeroLevel { get => heroLevel; set => heroLevel = value; }
   public int HeroStars { get => heroStars; set => heroStars = value; }
   public int HeroCp { get => heroCp; set => heroCp = value; }
   public IHeroClassAsset HeroClass { get => heroClass as IHeroClassAsset; set => heroClass = value as ScriptableObject; }
   public IHeroRaceAsset HeroRace { get => heroRace as IHeroRaceAsset; set => heroRace = value as ScriptableObject; }
   
   public IHeroAsset HeroAsset { get => heroAsset as IHeroAsset; set => heroAsset = value as ScriptableObject; }
   
   //Hero Asset (used in Skills Initialization)

   
   #endregion
        
   #region METHODS

        

   #endregion
}
