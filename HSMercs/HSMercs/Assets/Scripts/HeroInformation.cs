using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;

public class HeroInformation : MonoBehaviour, IHeroInformation
{
   #region VARIABLES
   
   [Header("Hero Information")]
   
   [SerializeField] private string heroName;
   
   [SerializeField] private int heroLevel;
   [SerializeField] private int heroStars;
   [SerializeField] private int heroCp;
   [SerializeField] private Sprite heroSprite;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroClassAsset))] private ScriptableObject heroClass = null;

   #endregion
        
   #region PROPERTIES
   
   //HERO INFORMATION
   public string HeroName { get => heroName; set => heroName = value; }
   
   public Sprite HeroSprite { get => heroSprite; set => heroSprite = value; }
   public int HeroLevel { get => heroLevel; set => heroLevel = value; }
   public int HeroStars { get => heroStars; set => heroStars = value; }
   public int HeroCp { get => heroCp; set => heroCp = value; }
   public IHeroClassAsset HeroClass { get => heroClass as IHeroClassAsset; set => heroClass = value as ScriptableObject; }

   
   #endregion
        
   #region METHODS

        

   #endregion
}
