﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SkillPanelVisual : MonoBehaviour, ISkillPanelVisual
{

    [SerializeField] private Canvas skillPanelCanvas;
    [SerializeField] private Image greenPanel;
    [SerializeField] private Image bluePanel;
    [SerializeField] private Image redPanel;
    [SerializeField] private Transform skillGridTransform;
    
    
    
    #region Properties

    public Image GreenPanel { get => greenPanel; private set => greenPanel = value; }
    
    public Image BluePanel { get => bluePanel; private set => bluePanel = value; }
    
    public Image RedPanel { get => redPanel; private set => redPanel = value; }
    
    public Transform SkillGridTransform { get => skillGridTransform; private set => skillGridTransform = value; }

    public Canvas SkillPanelCanvas { get => skillPanelCanvas; private set => skillPanelCanvas = value; }

    public GameObject ThisGameObject => this.gameObject;

    

    #endregion



}
