﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SkillTargeting : MonoBehaviour, ISkillTargeting
{
    
    [SerializeField] private float distanceMultiplier = 40;
    
    private ISkillTargetCollider SkillTargetCollider { get; set; }

    #region METHODS
    
    private void Awake()
    {
        SkillTargetCollider = GetComponent<ISkillTargetCollider>();
    }
    
    /// <summary>
    /// Enables the targeting component visuals - cross hair, triangle, and line renderer.
    /// Also enables draggable. 
    /// </summary>
    public void EnableSkillTargeting()
    {
        var currentSkill = SkillTargetCollider.Skill;
        var selectedSkill = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill;

        //Cancel Selected skill by clicking on it
        if (selectedSkill == currentSkill)
        {
            //Reset selected skill and targets
            SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill = null;
            SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedTarget = null;
            SkillTargetCollider.ManualSelectTarget.LocalSkillSelectedTarget = null;
         
            //Disable skill targeting
            SkillTargetCollider.SkillTargeting.DisableSkillTargeting();
        }
        //Enable skill targeting for a different skill
        else 
        {
         
            //Enables and updates information on show skill preview
            SkillTargetCollider.Skill.SkillVisual.SkillPreviewVisual.ShowSkillPreview.TurnOn();
        
            //Only show target visuals after confirming skill is both ready and is enabled
            SkillTargetCollider.Skill.SkillAttributes.SkillReadiness.EnableTargetVisuals(transform,SkillTargetCollider);
        }
        
       
    }
    
    /// <summary>
    /// Disables the targeting component visuals - cross hair, triangle, and line renderer
    /// Also disables draggable.
    /// </summary>
    public void DisableSkillTargeting()
    {
        transform.localPosition = Vector3.zero;
        //SkillTargetCollider.TargetArrow.SetActive(false);
        SkillTargetCollider.Draggable.DisableDraggable();
        SkillTargetCollider.TargetNodes.HideArrowNodes();
        
        HideTargetCrossHair();
        
        HideArrow();
        
        SkillTargetCollider.Skill.SkillVisual.SkillPreviewVisual.ShowSkillPreview.TurnOff();
        
        SkillTargetCollider.SkillTargets.HideValidTargetsGlow();

        SkillTargetCollider.Skill.SkillVisual.SkillGraphics.SkillCheckGraphic.enabled = false;

    }

    
    /// <summary>
    /// Used by Draggable.cs to display the line and target sprites
    /// </summary>
    public void ShowLineAndTarget()
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
            
            SkillTargetCollider.Skill.SkillVisual.SkillPreviewVisual.ShowSkillPreview.TurnOff();
        }
        else  //if there is NO distance between skill position and mouse position
        {
            HideArrow();
            SkillTargetCollider.TargetNodes.HideArrowNodes();
            SkillTargetCollider.Skill.SkillVisual.SkillPreviewVisual.ShowSkillPreview.TurnOn();    
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
    
    private void HideTargetCrossHair()
    {
        SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = false;
    }
    
    
    #endregion

    #region TEST
    
    
    /// <summary>
    /// Shows the cross hair at target hero
    /// </summary>
    /// <param name="hero"></param>
    public void ShowCrossHairAtTargetHero(IHero hero)
    {
        var heroTransform = hero.HeroTransform;

        SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = true;
        
        SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.transform.position =
            heroTransform.position;
    }
    
    public void ShowArrowAtTargetHero(IHero targetHero)
    {
        var targetHeroTransform = targetHero.HeroTransform;
        var position = targetHeroTransform.position;
        var notNormalizedTarget = position - transform.parent.position;
        
        //var notNormalizedTarget = transform.parent.position - targetHeroTransform.position;
        
        var directionTarget = notNormalizedTarget.normalized;
        
            
        var rotZ = Mathf.Atan2(notNormalizedTarget.y, notNormalizedTarget.x) * Mathf.Rad2Deg;
        
        //SkillTargetCollider.TargetArrow.SetActive(true);

        SkillTargetCollider.TargetArrow.GetComponent<Image>().enabled = true;
        
        //SkillTargetCollider.TargetArrow.transform.position = transform.position - 15f * directionTarget;
        SkillTargetCollider.TargetArrow.transform.position = position - 15f * directionTarget;
        
        SkillTargetCollider.TargetArrow.transform.rotation = Quaternion.Euler(0f,0f,rotZ-90);
    }

    

    #endregion
        


}
