using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusEffectPreviewVisual : MonoBehaviour, IStatusEffectPreviewVisual
{
    [SerializeField] private Image statusEffectFrame;
    [SerializeField] private TextMeshProUGUI previewName;
    [SerializeField] private TextMeshProUGUI previewInformation;

    #region PROPERTIES

    /// <summary>
    /// Returns/Sets the image of the status effect's background frame
    /// </summary>
    public Image StatusEffectFrame { get => statusEffectFrame; set => statusEffectFrame = value; }
    
    /// <summary>
    /// Returns/Sets the name of the status effect in the hero preview 
    /// </summary>
    public TextMeshProUGUI PreviewName { get => previewName; set => previewName = value; }
    
    /// <summary>
    /// Returns/sets the status effect's information in the hero preview
    /// </summary>
    public TextMeshProUGUI PreviewInformation { get => previewInformation; set => previewInformation = value; }

    #endregion
}
