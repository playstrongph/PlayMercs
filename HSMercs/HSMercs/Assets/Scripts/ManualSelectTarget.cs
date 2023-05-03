using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
   [SerializeField] private Object selectedTarget = null;

   #endregion
        
   #region PROPERTIES

   private ISkillTargetCollider SkillTargetCollider { get; set; }
   
   private IHero SelectedTarget
   {
      get => selectedTarget as IHero;
      set => selectedTarget = value as Object;
   }


   #endregion
        
   #region METHODS

   private void Awake()
   {
      SkillTargetCollider = GetComponent<ISkillTargetCollider>();
   }

   public void SetValidTargetHero()
   {
      //Returns a valid target or null if there's none
      GetSelectedTarget();
      
      //If there's a valid target
      if (SelectedTarget != null)
      {
         HideHeroSkillsOnDisplay();

         SetSelectedSkill();
      }
   }
   
   /// <summary>
   /// TEST
   ///  Cancels the selected skill if it's clicked again
   ///  Is this better to implement as an SO Enum? 
   /// </summary>
   public void CancelSelectedSkill()
   {
      var currentSkill = SkillTargetCollider.Skill;
      var selectedSkill = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill;

      if (selectedSkill == currentSkill)
      {
         //NULL both selected target and selected skill
         SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill = null;
         SelectedTarget = null;
         
         SkillTargetCollider.DrawTargetLineAndArrow.DisableTargetVisuals();
         
         HideHeroSkillsOnDisplay();
      }
   }


   /// <summary>
   /// Get Selected target from valid targets
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
      SelectedTarget = null;
      SkillTargetCollider.SkillTargets.ClearValidTargets();

      for (int i = 0; i < hitsCount; i++)
      {
         
         if (mResults[i].transform.GetComponent<IHeroTargetCollider>() != null)
         {
            var targetHeroCollider = mResults[i].transform.GetComponent<IHeroTargetCollider>();
            
            SelectedTarget = validTargets.Contains(targetHeroCollider.Hero) ? targetHeroCollider.Hero : null;
            
            //If there is a valid selected target
            if (validTargets.Contains(targetHeroCollider.Hero))
            {
               SelectedTarget = targetHeroCollider.Hero;
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
      
      casterPlayer.HeroSkillsOnDisplay?.ThisGameObject.SetActive(false);
      otherPlayer.HeroSkillsOnDisplay?.ThisGameObject.SetActive(false);
      
   }
   
   
   /// <summary>
   /// Sets the selected skill as the skill on queue if 
   /// </summary>
   private void SetSelectedSkill()
   {
      var skill = SkillTargetCollider.Skill;

      skill.CasterHero.HeroSkills.SelectedSkill = skill;
   }

   #endregion
}
