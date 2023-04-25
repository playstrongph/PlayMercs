using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;

public class HeroInformation : MonoBehaviour, IHeroInformation
{
   #region VARIABLES
   
   
   [Header("Hero Information")]
   [Header("SET IN RUNTIME")]
   
   [SerializeField] private string heroName;
   
   [SerializeField] private int heroLevel;
   [SerializeField] private int heroStars;
   [SerializeField] private int heroCp;
   [SerializeField] private Sprite heroSprite;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroClassAsset))] private ScriptableObject heroClass = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroRaceAsset))] private ScriptableObject heroRace = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAllianceAsset))] private ScriptableObject playerAlliance = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroAsset))] private ScriptableObject heroAsset = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillEnableAsset))] private ScriptableObject skillEnableAsset = null;
   
   
   

   #endregion
        
   #region PROPERTIES
   
   //HERO INFORMATION
   public string HeroName { get => heroName; set => heroName = value; }
   public Sprite HeroSprite { get => heroSprite; set => heroSprite = value; }
   public int HeroLevel { get => heroLevel; set => heroLevel = value; }
   public int HeroStars { get => heroStars; set => heroStars = value; }
   public int HeroCp { get => heroCp; set => heroCp = value; }
   
   /// <summary>
   /// Classes - Caster, Fighter, and Defender
   /// </summary>
   public IHeroClassAsset HeroClass { get => heroClass as IHeroClassAsset; set => heroClass = value as ScriptableObject; }
   
   /// <summary>
   /// Classes - Orc, Human, Demon, Elf, etc.
   /// </summary>
   public IHeroRaceAsset HeroRace { get => heroRace as IHeroRaceAsset; set => heroRace = value as ScriptableObject; }
   
   /// <summary>
   /// Alliances - Enemy or Ally Player
   /// </summary>
   public IPlayerAllianceAsset PlayerAlliance { get => playerAlliance as IPlayerAllianceAsset; set => playerAlliance = value as ScriptableObject; }
   
   public IHeroAsset HeroAsset { get => heroAsset as IHeroAsset; set => heroAsset = value as ScriptableObject; }
   public ISkillEnableAsset SkillEnableAsset { get => skillEnableAsset as ISkillEnableAsset; set => skillEnableAsset = value as ScriptableObject; }
   
   

   
   #endregion
        
   #region METHODS

        

   #endregion
}
