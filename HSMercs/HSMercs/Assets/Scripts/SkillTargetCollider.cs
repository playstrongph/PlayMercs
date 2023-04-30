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

    private IManualSelectTarget ManualSelectTarget { get; set; }

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
        //Show Targeting Visuals
        DrawTargetLineAndArrow.EnableTargetVisuals();
        
        //Show Valid Targets Glow
        SkillTargets.ShowValidTargetsGlow();
    }
        
    private void OnMouseUp()
    {
        //Hide Targeting Visuals
        DrawTargetLineAndArrow.DisableTargetVisuals();
        
        //Hide Valid Targets Glow
        SkillTargets.HideValidTargetsGlow();
        
        //Select Target Hero From Valid Targets
        ManualSelectTarget.SetValidTargetHero();


    }
    
}
