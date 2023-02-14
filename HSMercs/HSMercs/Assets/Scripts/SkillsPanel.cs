using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsPanel : MonoBehaviour, ISkillsPanel
{

    #region VARIABLES

    

    #endregion

    #region PROPERTIES

    public ISkillsPanelVisual SkillsPanelVisual { get; private set; }


    #endregion


    #region METHODS

    private void Awake()
    {
        SkillsPanelVisual = GetComponent<ISkillsPanelVisual>();
    }

    #endregion
    
}
