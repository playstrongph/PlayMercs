using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillGraphics : MonoBehaviour, ISkillGraphics
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
    [SerializeField] private Image crossHairGraphic;

    [Header("SKILL TEXTS")] 
    [SerializeField] private TextMeshProUGUI skillReadyText;
    [SerializeField] private TextMeshProUGUI skillNotReadyText;

    #region PROPERTIES

    //FRAME IMAGES
    public Image SkillReadyFrame { get => skillReadyFrame; private set => skillReadyFrame = value; } 
    public Image SkillNotReadyFrame { get => skillNotReadyFrame; private set => skillNotReadyFrame = value; }
    public Image PassiveSkillFrame { get => passiveSkillFrame; private set => passiveSkillFrame = value; }
    
    //SKILL IMAGES
    public Image SkillReadyGraphic { get => skillReadyGraphic; private set => skillReadyGraphic = value; }
    public Image SkillNotReadyGraphic { get => skillNotReadyGraphic; private set => skillNotReadyGraphic = value; }
    public Image PassiveSkillGraphic { get => passiveSkillGraphic; private set => passiveSkillGraphic = value; }
    public Image TargetArrow { get => targetArrow; private set => targetArrow = value; }
    public Image CrossHairGraphic { get => crossHairGraphic; private set => crossHairGraphic = value; }
    
    //SKILL TEXTS
    public TextMeshProUGUI SkillReadyText { get => skillReadyText; private set => skillReadyText = value; }
    public TextMeshProUGUI SkillNotReadyText { get => skillNotReadyText; private set => skillNotReadyText = value; }

    #endregion
    
    

}
