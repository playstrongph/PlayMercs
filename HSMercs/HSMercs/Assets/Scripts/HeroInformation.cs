using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInformation : MonoBehaviour, IHeroInformation
{
   #region VARIABLES
   
   [Header("Hero Information")]
   
   [SerializeField] private string heroName;
   [SerializeField] private string heroClass;
   [SerializeField] private int heroLevel;
   [SerializeField] private int heroStars;
   [SerializeField] private int heroCp;
   [SerializeField] private Sprite heroSprite;

   #endregion
        
   #region PROPERTIES
   
   //HERO INFORMATION
   public string HeroName { get => heroName; private set => heroName = value; }  
   public string HeroClass { get => heroClass; private set => heroClass = value; }
   public Sprite HeroSprite { get => heroSprite; private set => heroSprite = value; }
   public int HeroLevel { get => heroLevel; private set => heroLevel = value; }
   public int HeroStars { get => heroStars; private set => heroStars = value; }
   public int HeroCp { get => heroCp; private set => heroCp = value; }

   #endregion
        
   #region METHODS

        

   #endregion
}
