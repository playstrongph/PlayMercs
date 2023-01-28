using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillVisual : MonoBehaviour
{
    [SerializeField] private Canvas skillCanvas;
    
    [Header("FRAME IMAGES")]
    [SerializeField] private Image skillReadyFrame;
    [SerializeField] private Image skillNotReadyFrame;
    [SerializeField] private Image passiveSkillFrame;
    
    [Header("SKILL IMAGES")]
    [SerializeField] private Image skillReadyGraphic;
    [SerializeField] private Image skillNotReadyGraphic;
    [SerializeField] private Image passiveSkillGraphic;
    [SerializeField] private Image targetArrow;

    [Header("SKILL TEXTS")] 
    [SerializeField] private TextMeshProUGUI skillReadyText;
    [SerializeField] private TextMeshProUGUI skillNotReadyText;

}
