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
        //GetSkillTargets = GetComponent<IGetSkillTargets>();
    }
    
    private void OnMouseDown()
    {
        DrawTargetLineAndArrow.EnableTargetVisuals();
    }
        
    private void OnMouseUp()
    {
        DrawTargetLineAndArrow.DisableTargetVisuals();
    }
    
}
