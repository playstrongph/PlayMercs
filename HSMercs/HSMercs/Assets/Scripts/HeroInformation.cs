using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInformation : MonoBehaviour, IHeroInformation
{
   #region VARIABLES
   
   [Header("Hero Information")]
   
   [SerializeField] private string heroName;
   [SerializeField] private string heroClassText;
   [SerializeField] private int heroLevel;
   [SerializeField] private int heroStars;
   [SerializeField] private int heroCp;
   [SerializeField] private Sprite heroSprite;
   

   #endregion
        
   #region PROPERTIES
   
   //HERO INFORMATION
   public string HeroName { get => heroName; set => heroName = value; }  
   public string HeroClassText { get => heroClassText; set => heroClassText = value; }
   public Sprite HeroSprite { get => heroSprite; set => heroSprite = value; }
   public int HeroLevel { get => heroLevel; set => heroLevel = value; }
   public int HeroStars { get => heroStars; set => heroStars = value; }
   public int HeroCp { get => heroCp; set => heroCp = value; }

   #endregion
        
   #region METHODS

        

   #endregion
}
