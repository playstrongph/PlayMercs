using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTargetCollider : MonoBehaviour, ISkillTargetCollider
{
    #region Variables
    
    [SerializeField] private GameObject targetArrow;
    [SerializeField] private LineRenderer targetLine;
    
    [SerializeField] private GameObject targetNode;
    
    [SerializeField] private Canvas targetCanvas;
    
    public ISelectDragTarget SelectDragTarget { get; private set; }


    public IDraggable Draggable { get; private set; }

    #endregion

    #region Properties

    public GameObject TargetArrow { get => targetArrow; private set => targetArrow = value;}
    public LineRenderer TargetLine { get => targetLine; private set => targetLine = value;}
    
    public GameObject TargetNode { get => targetNode; private set => targetNode = value;}
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
