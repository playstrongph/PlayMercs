using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHeroAttackText : MonoBehaviour, ISetHeroAttackText
{
   #region VARIABLES

   private IHeroGraphics _heroGraphics;

   #endregion

   #region PROPERTIES

   public void SetValue(int textValue)
   {
      var baseAttack = _heroGraphics.Hero.BaseHeroStats.Attack;
      var currentAttack = _heroGraphics.Hero.HeroStats.Attack;
   
      _heroGraphics.AttackText.text = textValue.ToString();
      _heroGraphics.AttackText.color = SetTextColor(baseAttack, currentAttack);

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
