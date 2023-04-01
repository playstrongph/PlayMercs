using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SetHeroArmorText : MonoBehaviour, ISetHeroArmorText
{
   #region VARIABLES

   private IHeroGraphics _heroGraphics;

   #endregion

   #region PROPERTIES

   public void SetValue(int textValue)
   {
      _heroGraphics.ArmorText.text = textValue.ToString();
      
      ToggleIconDisplay(textValue);

   }

   #endregion

   #region METHODS

   public void Awake()
   {
      _heroGraphics = GetComponent<IHeroGraphics>();
   }
   
   private void ToggleIconDisplay(int value)
   {
      var armorImage = _heroGraphics.ArmorGraphic;
      var armorText = _heroGraphics.ArmorText;
      
      //if armor > 0 enabled, otherwise disabled
      armorImage.enabled = value > 0;
      armorText.enabled = value > 0;
   }

   #endregion
}
