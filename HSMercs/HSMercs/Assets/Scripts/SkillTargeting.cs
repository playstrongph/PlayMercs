using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SkillTargeting : MonoBehaviour, ISkillTargeting
{
    private ISkillTargetCollider SkillTargetCollider { get; set; }

    #region METHODS
    
    private void Awake()
    {
        SkillTargetCollider = GetComponent<ISkillTargetCollider>();
    }
    
    
    /// <summary>
    /// Checks if the skill is active/basic, ready, and enabled state
    /// </summary>
    public void CheckEnableSkillTargetingPermissive()
    {
        //First Check is the skill type
        SkillTargetCollider.Skill.SkillAttributes.SkillType.EnableSkillTargeting(SkillTargetCollider.Skill);
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
            var skillQueue = SkillTargetCollider.Skill.CasterHero.Player.BattleSceneManager.SkillQueue;
            
            //TEST: TODO: Remove skill from skill queue
            //RemoveSkillFromQueue();
            skillQueue.RemoveSkillFromQueue(SkillTargetCollider.Skill);
            
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
            //SkillTargetCollider.Skill.SkillVisual.SkillPreviewVisual.ShowSkillPreview.TurnOn();
        
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
        
        SkillTargetCollider.Draggable.DisableDraggable();
        SkillTargetCollider.TargetNodes.HideArrowNodes();
        
        HideTargetCrossHair();
        
        HideArrow();
        
        SkillTargetCollider.Skill.SkillVisual.SkillPreviewVisual.ShowSkillPreview.TurnOff();
        
        SkillTargetCollider.SkillTargets.HideValidTargetsGlow();

        SkillTargetCollider.Skill.SkillVisual.SkillGraphics.SkillCheckGraphic.enabled = false;

    }

    

    private void HideArrow()
    {
        SkillTargetCollider.TargetArrow.GetComponent<Image>().enabled = false;
    }

    private void HideTargetCrossHair()
    {
        SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = false;
    }
    
    

    #endregion

    #region TEST
    
    
   
    

    #endregion
        


}
