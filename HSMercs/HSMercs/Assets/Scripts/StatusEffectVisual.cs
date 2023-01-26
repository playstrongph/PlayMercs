using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusEffectVisual : MonoBehaviour, IStatusEffectVisual
{
    [SerializeField] private Image statusEffectFrame;
    [SerializeField] private Image statusEffectIcon;
    [SerializeField] private TextMeshProUGUI statusEffectCounters;

    #region PROPERTIES

    /// <summary>
    /// Returns/Sets the image of the status effect's background frame
    /// </summary>
    public Image StatusEffectFrame { get => statusEffectFrame; set => statusEffectFrame = value; }
    
    /// <summary>
    /// Returns/Sets the image of the status effect's background Icon 
    /// </summary>
    public Image StatusEffectIcon { get => statusEffectIcon; set => statusEffectIcon = value; }
    
    public TextMeshProUGUI StatusEffectCounters { get => statusEffectCounters; set => statusEffectCounters = value; }

    #endregion
    


}
