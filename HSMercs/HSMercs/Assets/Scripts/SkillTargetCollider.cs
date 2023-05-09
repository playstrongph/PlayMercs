using System.Collections;
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
    public IDrawTargetLineAndArrow DrawTargetLineAndArrow { get; private set; }
    public IDraggable Draggable { get; private set; }

    #endregion

    private void Awake()
    {
        DrawTargetLineAndArrow = GetComponent<IDrawTargetLineAndArrow>();
        Draggable = GetComponent<IDraggable>();
        SkillTargets = GetComponent<ISkillTargets>();
        ManualSelectTarget = GetComponent<IManualSelectTarget>();
    }
    
    /// <summary>
    /// Updates Selected skill and selected target based on skill type
    /// For passive skills, just display skill preview
    /// </summary>
    private void OnMouseDown()
    {
        Skill.SkillAttributes.SkillType.EnableSkillTargeting(Skill);
    }
     
    /// <summary>
    /// Hide Targeting Visuals and check if skill is Active or Basic, Skill Ready, Skill Enabled -> this hierarchy
    /// </summary>
    private void OnMouseUp()
    {
        //Hide Targeting Visuals
        DrawTargetLineAndArrow.DisableSkillTargeting();

        //Check if skill is Active or Basic, Skill Ready, Skill Enabled -> this hierarchy
        Skill.SkillAttributes.SkillType.SelectTarget(Skill);

    }

    
    

}
