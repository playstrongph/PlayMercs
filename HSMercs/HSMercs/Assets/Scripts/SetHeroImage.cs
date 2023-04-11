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
      
      //Hero Graphics
      _heroGraphics.GreenHeroGraphic.sprite = heroImage;
      _heroGraphics.RedHeroGraphic.sprite = heroImage;
      _heroGraphics.BlueHeroGraphic.sprite = heroImage;
      
      //Hero Preview
      _heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.GreenHeroGraphic.sprite = heroImage;
      _heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.RedHeroGraphic.sprite = heroImage;
      _heroGraphics.Hero.HeroVisual.HeroPreview.HeroGraphicPreview.BlueHeroGraphic.sprite = heroImage;
   }     

   #endregion
        
   #region METHODS

   private void Awake()
   {
      _heroGraphics = GetComponent<IHeroGraphics>();
   }

   #endregion
}
