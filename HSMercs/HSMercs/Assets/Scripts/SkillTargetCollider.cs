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

    //GameObject used because both Transform and Image components are utilized
    public GameObject TargetArrow { get => targetArrow; private set => targetArrow = value;}
    public ITargetNodes TargetNodes { get => targetNodes as ITargetNodes; private set => targetNodes = value as Object;}
    public Canvas TargetCanvas { get => targetCanvas; private set => targetCanvas = value;}
    
    public IDrawTargetLineAndArrow DrawTargetLineAndArrow { get; private set; }

    public IDraggable Draggable { get; private set; }

    #endregion

    private void Awake()
    {
        //DisplaySkillPreview = GetComponent<IDisplaySkillPreview>();
        DrawTargetLineAndArrow = GetComponent<IDrawTargetLineAndArrow>();
        Draggable = GetComponent<IDraggable>();
        SkillTargets = GetComponent<ISkillTargets>();
        ManualSelectTarget = GetComponent<IManualSelectTarget>();
    }
    
    private void OnMouseDown()
    {
        //Will Show skill preview - but will check for skill readiness and enabled status before enabling other
        //visuals
        DrawTargetLineAndArrow.EnableTargetVisuals();
        
        //TEST
        ManualSelectTarget.CancelSelectedSkill();
    }
        
    private void OnMouseUp()
    {
        //Hide Targeting Visuals
        DrawTargetLineAndArrow.DisableTargetVisuals();

        //Check if skill is Active or Basic, Skill Ready, Skill Enabled -> this hierarchy
        Skill.SkillAttributes.SkillType.SetValidTargetHero(Skill);

    }

    
    

}
