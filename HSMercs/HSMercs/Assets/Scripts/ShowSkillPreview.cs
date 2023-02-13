﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSkillPreview : MonoBehaviour, IShowSkillPreview
{

    #region VARIABLES

    [SerializeField] private Canvas skillPreviewCanvas = new Canvas();
    [SerializeField] private float displayDelay = 0.5f;
    
    private bool _enablePreview = false;
    
    #endregion

    #region PROPERTIES

    #endregion
    
    private void OnMouseDown()
    {
        _enablePreview = true;
        StartCoroutine(ShowPreview());
    }
        
    private void OnMouseUp()
    {
        _enablePreview = false;
        skillPreviewCanvas.enabled = false;
    }

    private void OnMouseExit()
    {
        _enablePreview = false;
        skillPreviewCanvas.enabled = false;
    }


    /// <summary>
    /// Turn On Skill Preview
    /// </summary>
    public void TurnOn()
    {
        //skillPreviewCanvas.enabled = true;
    }

    /// <summary>
    /// Turn Off Skill Preview
    /// </summary>
    public void TurnOff()
    {
        skillPreviewCanvas.enabled = false;
    }
    
    private IEnumerator ShowPreview()
    {
        yield return new WaitForSeconds(displayDelay);
        if (_enablePreview)
        {
            skillPreviewCanvas.enabled = true;
        }
    }


}
