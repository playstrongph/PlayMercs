﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkillTargetDisplay : MonoBehaviour, ISkillTargetDisplay
{
   #region VARIABLES
   
   [SerializeField] private float distanceMultiplier = 40;
   
   private ISkillTargetCollider SkillTargetCollider { get; set; } = null;

   #endregion
        
   #region PROPERTIES

   private void Awake()
   {
      SkillTargetCollider = GetComponent<ISkillTargetCollider>();
   }


   #endregion
        
   #region METHODS
   
   /// <summary>
   /// Hides and disables the skill targeting visuals (arrow, nodes, and cross hair)
   /// </summary>
   /*public void HideVisuals()
   {
      var selectedSkill = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill;
      
      if(selectedSkill != null)
         selectedSkill.SkillTargetCollider.SkillTargeting.DisableSkillTargeting();
   }*/

   public void HideVisuals()
   {
      var selectedSkill = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill;
      var selectedTarget = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedTarget;

      if (selectedSkill != null)
      {
         //Hide Arrow
         selectedSkill.SkillTargetCollider.TargetArrow.GetComponent<Image>().enabled = false;
         
         //Hide CrossHair
         selectedSkill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = false;
         
         //Hide Nodes
         selectedSkill.SkillTargetCollider.TargetNodes.HideArrowNodes();
         
      }
      
   }


   /// <summary>
   /// Enables and displays the skill target visuals (arrow, nodes, and cross hair) 
   /// </summary>
   public void ShowVisuals()
   {
      var selectedSkill = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill;
      var selectedTarget = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedTarget;
         
      if (selectedSkill != null)
      {
         
         //selectedSkill.SkillTargetCollider.SkillTargeting.ShowArrowAtTargetHero(selectedTarget);
         ShowArrowAtTargetHero(selectedTarget,selectedSkill);
         ShowCrossHairAtTargetHero(selectedTarget,selectedSkill);
         
         selectedSkill.SkillTargetCollider.TargetNodes.ShowNodesAtTargetHero(selectedTarget,selectedSkill);
         
         selectedSkill.SkillVisual.SkillGraphics.SkillCheckGraphic.enabled = true;
      }
   }
   
   /// <summary>
   /// Shows the cross hair at target hero
   /// </summary>
   /// <param name="hero"></param>
   ///  <param name="skill"></param>
   private void ShowCrossHairAtTargetHero(IHero hero, ISkill skill)
   {
      var heroTransform = hero.HeroTransform;

      skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = true;
        
      skill.SkillVisual.SkillGraphics.CrossHairGraphic.transform.position =
         heroTransform.position;
   }
   
   /// <summary>
   /// Shows the Arrow at the Target Hero
   /// </summary>
   /// <param name="selectedTarget"></param>
   /// <param name="selectedSkill"></param>
   private void ShowArrowAtTargetHero(IHero selectedTarget, ISkill selectedSkill)
   {
      
      var targetHeroPosition = selectedTarget.HeroTransform.position;
      var selectedSkillPosition = selectedSkill.ThisGameObject.transform.position;
      var notNormalizedTarget = targetHeroPosition - selectedSkillPosition;
      var directionTarget = notNormalizedTarget.normalized;
      var rotZ = Mathf.Atan2(notNormalizedTarget.y, notNormalizedTarget.x) * Mathf.Rad2Deg;
      

      selectedSkill.SkillTargetCollider.TargetArrow.GetComponent<Image>().enabled = true;
      
      selectedSkill.SkillTargetCollider.TargetArrow.transform.position = targetHeroPosition - 15f * directionTarget;
        
      selectedSkill.SkillTargetCollider.TargetArrow.transform.rotation = Quaternion.Euler(0f,0f,rotZ-90);
   }
   
   
   /// <summary>
   /// Shows the line, arrow, and cross hair
   /// </summary>
   public void ShowLineArrowAndCrossHair()
   {
      var thisTransform = transform;
      var notNormalized = thisTransform.position - thisTransform.parent.position;
      var direction = notNormalized.normalized;
      var distanceFromHero = (direction*distanceMultiplier).magnitude;
      var difference = notNormalized.magnitude - distanceFromHero;
      var intDifference = Mathf.RoundToInt(difference);
      var distanceLimit = 0f;  //default value is zero

      if (intDifference > distanceLimit)  //if there is some distance between skill position and mouse position
      {
         ShowArrow(notNormalized,direction);
            
         SkillTargetCollider.TargetNodes.ShowArrowNodes();
            
         ShowTargetCrossHair();
         
      }
      else  //if there is NO distance between skill position and mouse position
      {
         HideArrow();
         SkillTargetCollider.TargetNodes.HideArrowNodes();
      }

        
   }
   
    private void ShowArrow(Vector3 notNormalized, Vector3 direction)
    {
        var rotZ = Mathf.Atan2(notNormalized.y, notNormalized.x) * Mathf.Rad2Deg;
        
        //SkillTargetCollider.TargetArrow.SetActive(true);

        SkillTargetCollider.TargetArrow.GetComponent<Image>().enabled = true;
        SkillTargetCollider.TargetArrow.transform.position = transform.position - 15f * direction;
        SkillTargetCollider.TargetArrow.transform.rotation = Quaternion.Euler(0f,0f,rotZ-90);
            
        //Disable Hero Preview
        //SkillTargetCollider.DisplaySkillPreview.HidePreview();  //Temp Disable
    }

    private void HideArrow()
    {
        SkillTargetCollider.TargetArrow.GetComponent<Image>().enabled = false;
    }

    private void ShowTargetCrossHair()
    {
        // ReSharper disable once PossibleNullReferenceException
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Store at most 5 ray cast hits
        var mResults = new RaycastHit[5];
            
        //ray traverses all layers
        var layerMask = ~0;
            
        //Same to RayCastAll but with no additional garbage
        int hitsCount = Physics.RaycastNonAlloc(ray, mResults, Mathf.Infinity,layerMask);
            
        //Update the latest targeted hero to null
        //_validSkillTargetHero = null;
            
        //SkillTargetCollider.Skill.CasterHero.HeroLogic.LastHeroTargets.SetTargetedHero(_validSkillTargetHero);
        
        //Hide target cross hair by default
        SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = false;

        for (int i = 0; i < hitsCount; i++)
        {
            if (mResults[i].transform.GetComponent<IHeroTargetCollider>() != null)
            {
                var heroGameObject = mResults[i];
                var heroTarget = heroGameObject.transform.GetComponent<IHeroTargetCollider>().Hero;
                var validHeroTargets = SkillTargetCollider.SkillTargets.GetValidTargets();
                
                //Check if the targeted hero is part of the valid targets before displaying the crosshair
                if (validHeroTargets.Contains(heroTarget))
                {
                    //Display cross hair
                    SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = true;
                
                    //Set cross hair position to position of target hero
                    SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.transform.position =
                        heroGameObject.transform.position;
                }
            }
        }
    }
   
   #endregion
   
   
   
   
}
