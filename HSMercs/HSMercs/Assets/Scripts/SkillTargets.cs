﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SkillTargets : MonoBehaviour
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private List<Object> validTargets = new List<Object>();

   #endregion

   #region PROPERTIES

   private ISkillTargetCollider SkillTargetCollider{ get; set; }

   private List<IHero> ValidTargets
   {
      get
      {
         var newValidTargets = new List<IHero>();
         foreach (var validTarget in validTargets)
         {
            newValidTargets.Add(validTarget as IHero);
         }

         return newValidTargets;
      }
   }

   #endregion

   #region METHODS

   private void Awake()
   {
      SkillTargetCollider = GetComponent<ISkillTargetCollider>();
   }

   public List<IHero> GetValidTargets()
   {
      var skill = SkillTargetCollider.Skill;
      
      return skill.SkillAttributes.SkillTarget.GetHeroTargets(skill.CasterHero);

      //Note: Special circumstances in targeting are resolved in SkillTarget.HeroTargets
   }
   
   



   #endregion
}
