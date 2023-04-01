using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHeroImage : MonoBehaviour, ISetHeroImage
{
   #region VARIABLES

   private IHeroGraphics _heroGraphics;     

   #endregion
        
   #region PROPERTIES

   public void SetValue()
   {
      
      var heroImage = _heroGraphics.Hero.HeroInformation.HeroSprite;
      
      //Temp - need to UsedHeroGraphic property in HeroGraphics class that is determined by the hero class
      _heroGraphics.GreenHeroGraphic.sprite = heroImage;
      _heroGraphics.RedHeroGraphic.sprite = heroImage;
      _heroGraphics.BlueHeroGraphic.sprite = heroImage;


   }     

   #endregion
        
   #region METHODS

   private void Awake()
   {
      _heroGraphics = GetComponent<IHeroGraphics>();
   }

   #endregion
}
