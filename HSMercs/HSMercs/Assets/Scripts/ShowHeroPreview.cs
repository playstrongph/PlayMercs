using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHeroPreview : MonoBehaviour, IShowHeroPreview
{
    
    #region VARIABLES

    [SerializeField] private Canvas heroPreviewCanvas = new Canvas();
    [SerializeField] private float displayDelay = 0.5f;

    private bool _enablePreview = false;

    #endregion

    /// <summary>
    /// Shows Hero Preview
    /// </summary>
    public void TurnOn()
    {
        _enablePreview = true;
        StartCoroutine(ShowPreview());
    }
    
    /// <summary>
    /// Show hero preview on Mouse Enter but after mousedown
    /// </summary>
    public void TurnOnMouseEnter()
    {
        StartCoroutine(ShowPreview());
    }
    
    /// <summary>
    /// Hides Hero Preview
    /// </summary>
    public void TurnOff()
    {
        _enablePreview = false;
        heroPreviewCanvas.enabled = false;
    }
    
    /// <summary>
    /// Turns off upon mouse exit but doesn't change the enable state
    /// </summary>
    public void TurnOffMouseExit()
    {
        heroPreviewCanvas.enabled = false;
    }



    /*private void OnMouseDown()
    {
        _enablePreview = true;
        StartCoroutine(ShowPreview());
    }
        
    private void OnMouseUp()
    {
        _enablePreview = false;
        heroPreviewCanvas.enabled = false;
    }
    
    private void OnMouseExit()
    {
        _enablePreview = false;
        heroPreviewCanvas.enabled = false;
    }
    
    private void OnMouseEnter()
    {
        _enablePreview = true;
        StartCoroutine(ShowPreview());
    }*/
    
    /// <summary>
    /// Waits for a delay before checking if preview is enabled
    /// </summary>
    /// <returns></returns>
    private IEnumerator ShowPreview()
    {
        yield return new WaitForSeconds(displayDelay);
        if (_enablePreview)
        {
            heroPreviewCanvas.enabled = true;
        }
    }

    
   





}
