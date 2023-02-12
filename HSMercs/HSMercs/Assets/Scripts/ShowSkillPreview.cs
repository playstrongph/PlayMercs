using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSkillPreview : MonoBehaviour, IShowSkillPreview
{

    #region VARIABLES
    
    [SerializeField] private Canvas skillPreviewCanvas;
    
    #endregion

    #region PROPERTIES

    private Canvas SkillPreviewVisual
    {
        get => skillPreviewCanvas; set => skillPreviewCanvas = value; }

    #endregion
    
    /// <summary>
    /// Turn On Skill Preview
    /// </summary>
    public void TurnOn()
    {
        SkillPreviewVisual.enabled = true;
    }

    /// <summary>
    /// Turn Offf Skill Preview
    /// </summary>
    public void TurnOff()
    {
        SkillPreviewVisual.enabled = false;
    }


}
