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

    private void OnMouseDown()
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
    }
    
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
