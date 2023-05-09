﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTargetCollider : MonoBehaviour, ISkillTargetCollider
{
    #region VARIABLES
    
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private Object skill;
    [SerializeField] private GameObject targetArrow;
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ITargetNodes))] private Object targetNodes;
    [SerializeField] private Canvas targetCanvas;

    #endregion

    #region PROPERTIES
    
    public ISkill Skill { get => skill as ISkill; private set => skill = value as Object;}
    public ISkillTargets SkillTargets { get; set; }
    public IManualSelectTarget ManualSelectTarget { get; private set; }
    public GameObject TargetArrow { get => targetArrow; private set => targetArrow = value;}
    public ITargetNodes TargetNodes { get => targetNodes as ITargetNodes; private set => targetNodes = value as Object;}
    public Canvas TargetCanvas { get => targetCanvas; private set => targetCanvas = value;}
    public ISkillTargeting SkillTargeting { get; private set; }
    public IDraggable Draggable { get; private set; }

    public ISkillTargetDisplay SkillTargetDisplay { get; set; }

    #endregion

    private void Awake()
    {
        SkillTargeting = GetComponent<ISkillTargeting>();
        Draggable = GetComponent<IDraggable>();
        SkillTargets = GetComponent<ISkillTargets>();
        ManualSelectTarget = GetComponent<IManualSelectTarget>();
        SkillTargetDisplay = GetComponent<ISkillTargetDisplay>();
    }
    
    /// <summary>
    /// Updates Selected skill and selected target based on skill type
    /// For passive skills, just display skill preview
    /// </summary>
    private void OnMouseDown()
    {
        //Checks the permissive for the 'EnableSkillTargeting' method
        Skill.SkillTargetCollider.SkillTargeting.CheckEnableSkillTargetingPermissive();
    }
     
    /// <summary>
    /// Hide Targeting Visuals and check if skill is Active or Basic, Skill Ready, Skill Enabled -> this hierarchy
    /// </summary>
    private void OnMouseUp()
    {
        //Hide Targeting Visuals
        SkillTargeting.DisableSkillTargeting();

        //Checks the permissive for the 'SelectTarget' method
        Skill.SkillTargetCollider.ManualSelectTarget.CheckSelectTargetPermissive();

    }

    
    

}
