﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTargetCollider : MonoBehaviour, ISkillTargetCollider
{
    #region Variables
    
    [SerializeField] private GameObject targetArrow;
    [SerializeField] private LineRenderer targetLine;
    [SerializeField] private Canvas targetCanvas;
    
    public ISelectDragTarget SelectDragTarget { get; private set; }
    
    #endregion

    #region Properties

    public GameObject TargetArrow { get => targetArrow; private set => targetArrow = value;}
    public LineRenderer TargetLine { get => targetLine; private set => targetLine = value;}
    public Canvas TargetCanvas { get => targetCanvas; private set => targetCanvas = value;}

    #endregion
    
    
    private void Awake()
    {
        //DisplaySkillPreview = GetComponent<IDisplaySkillPreview>();
        SelectDragTarget = GetComponent<ISelectDragTarget>();
        //Draggable = GetComponent<IDraggable>();
        //GetSkillTargets = GetComponent<IGetSkillTargets>();
    }
    
}
