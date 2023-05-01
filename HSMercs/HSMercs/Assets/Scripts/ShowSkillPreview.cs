using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowSkillPreview : MonoBehaviour, IShowSkillPreview
{

    #region VARIABLES

    [SerializeField] private Canvas skillPreviewCanvas = new Canvas();
    [SerializeField] private float displayDelay = 0.5f;
    private bool _enablePreview = false;

    private ISkill _skill;
    
    #endregion

    #region PROPERTIES

    #endregion


    #region METHODS

    private void Awake()
    {
        _skill = GetComponent<ISkillPreviewVisual>().Skill;
    }

    /// <summary>
    /// Can only turn on if within distance difference between the mouse location and the skill location
    /// Note that the collider moves with the mouse
    /// </summary>
    public void TurnOn()
    {
        _enablePreview = true;
        
        StartCoroutine(ShowPreview());
    }

    /// <summary>
    /// Turns off according to mouse location and skill position displacement
    /// </summary>
    public void TurnOff()
    {
        _enablePreview = false;
        skillPreviewCanvas.enabled = false;
    }
    
    private IEnumerator ShowPreview()
    {
        yield return new WaitForSeconds(displayDelay);
        if (_enablePreview)
        {
            skillPreviewCanvas.enabled = true;
            
            UpdateSkillPreviewVisualsInformation();
        }
    }
    
    /// <summary>
    /// Updates the skill preview information to the latest values
    /// TODO: Transfer this to skill graphics as a component
    /// </summary>
    private void UpdateSkillPreviewVisualsInformation()
    {
        var skillPreview = _skill.SkillVisual.SkillPreviewVisual;

        skillPreview.CooldownText.text = _skill.SkillAttributes.SkillCooldown.ToString();
        skillPreview.SpeedText.text = _skill.SkillAttributes.SkillSpeed.ToString();
        skillPreview.SkillDescriptionText.text = _skill.SkillAttributes.Description;
    }

    #endregion

}
