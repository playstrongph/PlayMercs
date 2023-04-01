using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHeroHealthText : MonoBehaviour, ISetHeroHealthText
{
   #region VARIABLES

   private IHeroGraphics _heroGraphics;

   #endregion

   #region PROPERTIES

   public void SetValue(int textValue)
   {
      var baseHealth = _heroGraphics.Hero.BaseHeroStats.Health;
      var currentHealth = _heroGraphics.Hero.HeroStats.Health;
   
      _heroGraphics.HealthText.text = textValue.ToString();
      _heroGraphics.HealthText.color = SetTextColor(baseHealth, currentHealth);

   }

   #endregion

   #region METHODS

   public void Awake()
   {
      _heroGraphics = GetComponent<IHeroGraphics>();
   }
   
   private Color SetTextColor(int baseValue, int value)
   {
      if(value>baseValue)
         return Color.green;
      else if (value == baseValue)
         return Color.white;
      else if(value < baseValue)
         return Color.red;
      else
         return Color.white;
   }

   #endregion
}
