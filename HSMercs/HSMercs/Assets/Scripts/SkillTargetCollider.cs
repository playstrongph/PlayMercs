using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTargetCollider : MonoBehaviour, ISkillTargetCollider
{
    #region Variables
    
    [SerializeField] private GameObject targetArrow;
   

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBezierNodes))]
    private Object bezierNodes;
    
    [SerializeField] private Canvas targetCanvas;
    
    public ISelectDragTarget SelectDragTarget { get; private set; }


    public IDraggable Draggable { get; private set; }

    #endregion

    #region Properties

    public GameObject TargetArrow { get => targetArrow; private set => targetArrow = value;}
    
    
    public IBezierNodes BezierNodes { get => bezierNodes as IBezierNodes; private set => bezierNodes = value as Object;}
    public Canvas TargetCanvas { get => targetCanvas; private set => targetCanvas = value;}

    #endregion
    
    
    private void Awake()
    {
        //DisplaySkillPreview = GetComponent<IDisplaySkillPreview>();
        SelectDragTarget = GetComponent<ISelectDragTarget>();
        Draggable = GetComponent<IDraggable>();
        //GetSkillTargets = GetComponent<IGetSkillTargets>();
    }
    
}
