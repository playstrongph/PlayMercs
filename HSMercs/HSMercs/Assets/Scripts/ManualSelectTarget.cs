﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Object = UnityEngine.Object;

public class ManualSelectTarget : MonoBehaviour, IManualSelectTarget
{
   #region VARIABLES

   /*/// <summary>
   /// List of valid hero targets taken during
   /// on mouse down event
   /// </summary>
   private List<IHero> _validTargets = new List<IHero>();*/
        
   /// <summary>
   /// The intended target hero for the skill being used
   /// reset to null when target selected is not valid
   /// </summary>
   //private IHero _validSkillTargetHero = null;

   
   [Header("SET IN RUN TIME")]
   [SerializeField] private Object localSkillSelectedTarget = null;

   #endregion
        
   #region PROPERTIES

   private ISkillTargetCollider SkillTargetCollider { get; set; }
   
   private IHero LocalSkillSelectedTarget
   {
      get => localSkillSelectedTarget as IHero;
      set => localSkillSelectedTarget = value as Object;
   }


   #endregion
        
   #region METHODS

   private void Awake()
   {
      SkillTargetCollider = GetComponent<ISkillTargetCollider>();
   }

   public void SetValidTargetHero()
   {
      //This is the current selected skill of the hero
      var selectedSkill = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill;

      //Returns a valid target, or null if there's none for Local Skill Selected Target
      GetSelectedTarget();
      
      //If there's a valid target
      if (LocalSkillSelectedTarget != null)
      {
         //Disable the visuals if there's a new valid selected target and selected skill
         selectedSkill?.SkillAttributes.SkillType.DisableTargetVisuals(selectedSkill);
         
         HideHeroSkillsOnDisplay();
         
         SetSelectedSkillAndTarget();
      }
   }
   
   /// <summary>
   /// Updates the latest skill and target;  Cancels the skill if selected previously
   /// </summary>
   public void UpdateSelectedSkillAndTarget()
   {
      var currentSkill = SkillTargetCollider.Skill;
      var selectedSkill = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill;
      
      //If there's already a previously selected skill, cancel the selected skill and target
      if (selectedSkill == currentSkill)
      {
         //NULL both selected target and selected skill
         SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill = null;
         SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedTarget = null;
         LocalSkillSelectedTarget = null;
         
         SkillTargetCollider.DrawTargetLineAndArrow.DisableTargetVisuals();

         HideHeroSkillsOnDisplay();
      }
      else
      {
         SkillTargetCollider.DrawTargetLineAndArrow.EnableTargetVisuals();   
      }

      
   }


   /// <summary>
   /// Gets a Local Selected target from valid targets
   /// Returns null if there is no valid target
   /// </summary>
   private void GetSelectedTarget()
   {
      // ReSharper disable once PossibleNullReferenceException
      var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

      //Store at most 5 ray cast hits
      var mResults = new RaycastHit[5];
            
      //ray traverses all layers
      var layerMask = ~0;
      
      //TODO: more checks if the hero is a valid target should be done here
      
      var validTargets = SkillTargetCollider.SkillTargets.GetValidTargets(); 
            
      //Same to RayCastAll but with no additional garbage
      int hitsCount = Physics.RaycastNonAlloc(ray, mResults, Mathf.Infinity,layerMask);
            
      //Update the latest targeted hero to null
      LocalSkillSelectedTarget = null;
      
      SkillTargetCollider.SkillTargets.ClearValidTargets();

      for (int i = 0; i < hitsCount; i++)
      {
         
         if (mResults[i].transform.GetComponent<IHeroTargetCollider>() != null)
         {
            var targetHeroCollider = mResults[i].transform.GetComponent<IHeroTargetCollider>();
            
            LocalSkillSelectedTarget = validTargets.Contains(targetHeroCollider.Hero) ? targetHeroCollider.Hero : null;
            
            //If there is a valid selected target
            if (validTargets.Contains(targetHeroCollider.Hero))
            {
               LocalSkillSelectedTarget = targetHeroCollider.Hero;
               //HideHeroSkillsOnDisplay();
            }
         }
      } // raycast for loop
   }
   
   
   /// <summary>
   /// Hide Skills On display after a valid target is selected
   /// </summary>
   private void HideHeroSkillsOnDisplay()
   {
      var casterPlayer = SkillTargetCollider.Skill.CasterHero.Player;
      var otherPlayer = SkillTargetCollider.Skill.CasterHero.Player.OtherPlayer;
      
      casterPlayer.HeroSkillsOnDisplay?.HeroSkillsVisual.HideSkillsDisplay();
      otherPlayer.HeroSkillsOnDisplay?.HeroSkillsVisual.HideSkillsDisplay();
   }

   /// <summary>
   /// Sets the selected skill and target  
   /// </summary>
   private void SetSelectedSkillAndTarget()
   {
      var skill = SkillTargetCollider.Skill;

      skill.CasterHero.HeroSkills.SelectedSkill = skill;
      skill.CasterHero.HeroSkills.SelectedTarget = LocalSkillSelectedTarget;
   }

   #endregion

   #region TEST

   #endregion
}
