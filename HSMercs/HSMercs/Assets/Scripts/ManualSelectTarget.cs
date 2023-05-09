using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Object = UnityEngine.Object;

public class ManualSelectTarget : MonoBehaviour, IManualSelectTarget
{
   #region VARIABLES

   [Header("SET IN RUN TIME")]
   [SerializeField] private Object localSkillSelectedTarget = null;

   #endregion
        
   #region PROPERTIES

   private ISkillTargetCollider SkillTargetCollider { get; set; }
   
   /// <summary>
   /// This the hero target of this skill
   /// </summary>
   public IHero LocalSkillSelectedTarget
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
   
   /// <summary>
   ///  Checks if the skill is active/basic, ready, and enabled state
   /// </summary>
   public void CheckSelectTargetPermissive()
   {
      SkillTargetCollider.Skill.SkillAttributes.SkillType.SelectTarget(SkillTargetCollider.Skill);
   }



   /// <summary>
   /// Sets the valid target hero 
   /// </summary>
   public void SelectTarget()
   {
      //This is the current selected skill of the hero
      var selectedSkill = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill;
      
      //Returns a valid target, or null if there's none for Local Skill Selected Target
      GetSelectedTarget();
      
      //Displays the skill target visuals (nodes, arrow, cross hair) between the skill and its target hero
      SkillTargetCollider.SkillTargetDisplay.ShowVisuals();

      //If there's a valid target, disable the last selected skill visuals and display the current one
      if (LocalSkillSelectedTarget != null)
      {
         //Note: This means skill is successfully cast

         //Displays the skill check icon of the new selected skill
         SkillTargetCollider.Skill.SkillVisual.SkillGraphics.SkillCheckGraphic.enabled = true;

         //Disable the skill target visuals (nodes, arrow, cross hair) of the last selected skill
         selectedSkill?.SkillAttributes.SkillType.DisableTargetVisuals(selectedSkill);
         
         //Hide the hero skills panel after successfully choosing a target
         HideSkillsDisplayAndScaleBackHero();
         
         //This is the Hero Skills' latest selected skill and selected target
         SetSelectedSkillAndTarget();
         
         //Find next hero
         ShowNextHeroWithoutSelectedSkill();

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
      var validTargets = SkillTargetCollider.SkillTargets.GetValidTargets(); 
            
      //Same to RayCastAll but with no additional garbage
      int hitsCount = Physics.RaycastNonAlloc(ray, mResults, Mathf.Infinity,layerMask);
            
      //Set the local skill selected target to null
      LocalSkillSelectedTarget = null;
      //Clear the list of valid targets
      SkillTargetCollider.SkillTargets.ClearValidTargets();

      for (var i = 0; i < hitsCount; i++)
      {
         //If raycast finds a hero
         if (mResults[i].transform.GetComponent<IHeroTargetCollider>() != null)
         {
            var targetHero = mResults[i].transform.GetComponent<IHeroTargetCollider>().Hero;
            
            //Set the local skill selected target hero to the hero found if it belongs to the list of valid targets, else set it to null
            LocalSkillSelectedTarget = validTargets.Contains(targetHero) ?targetHero : null;
         }
      } 
   }
   
   
   /// <summary>
   /// Hide skills on display and scale back targeting hero to normal size after a valid target is selected
   /// </summary>
   private void HideSkillsDisplayAndScaleBackHero()
   {
      var casterPlayer = SkillTargetCollider.Skill.CasterHero.Player;
      var otherPlayer = SkillTargetCollider.Skill.CasterHero.Player.OtherPlayer;
      
      casterPlayer.HeroSkillsOnDisplay?.HeroSkillsVisual.HideSkillsDisplayAndScaleBackHero();
      otherPlayer.HeroSkillsOnDisplay?.HeroSkillsVisual.HideSkillsDisplayAndScaleBackHero();
   }

   /// <summary>
   /// Sets HeroSkills' selected skill and target to the local skill and its selected target
   /// </summary>
   private void SetSelectedSkillAndTarget()
   {
      var skill = SkillTargetCollider.Skill;
      
      //Updates the hero skills selected skill and target to the local skill and its selected target
      skill.CasterHero.HeroSkills.SelectedSkill = skill;
      skill.CasterHero.HeroSkills.SelectedTarget = LocalSkillSelectedTarget;
   }
   
   
   /// <summary>
   /// Display the next hero without a selected skill 
   /// </summary>
   private void ShowNextHeroWithoutSelectedSkill()
   {
      var allyHeroList = SkillTargetCollider.Skill.CasterHero.Player.BattleSceneManager.MainPlayer.Heroes.HeroStatusLists.GetAliveHeroList();
      var invertedAllyHeroList = new List<IHero>(allyHeroList);
      
      //List is inverted so that the order of displaying heroes will be towards the "RIGHT" direction
      invertedAllyHeroList.Reverse();
      
      //This is the closest hero to the "RIGHT" of the hero with a skill selected
      IHero nextHero = null;
      
      foreach (var hero in invertedAllyHeroList)
      {
         var selectedSkill = hero.HeroSkills.SelectedSkill;
         if (selectedSkill == null)
         {
            nextHero = hero;
         }
      }
      
      //If there's a next hero, trigger the "OnMouseDown" actions
      nextHero?.HeroTargetCollider.SelectHeroActions();

   }

   #endregion
   
   
   #region TEST
   
   #endregion
}
