using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class QueueSkillPreviewVisual : MonoBehaviour
{
    #region VARIALBES

    [Header("PREVIEW IMAGES")]
    [SerializeField] private Image redFrame;
    [SerializeField] private Image greenFrame;
    [SerializeField] private Image blueFrame;
    [SerializeField] private Image previewImage;
    [SerializeField] private Image speedIcon;
    [SerializeField] private Image cooldownIcon;
    [SerializeField] private Image arrowIcon;
    [SerializeField] private Image arrowGlow;
    
    
    [Header("PREVIEW TEXTS")]
    [SerializeField] private TextMeshProUGUI speedText;
    [SerializeField] private TextMeshProUGUI cooldownText;
    [SerializeField] private TextMeshProUGUI skillNameText;
    [SerializeField] private TextMeshProUGUI skillDescriptionText;
    [SerializeField] private TextMeshProUGUI skillElementText;

    

    #endregion

    #region PROPERTIES

    public Image RedFrame { get => redFrame; private set => redFrame = value; }
    public Image GreenFrame { get => greenFrame; private set => greenFrame = value; }
    public Image BlueFrame { get => blueFrame; private set => blueFrame = value; }
    public Image PreviewImage { get => previewImage; private set => previewImage = value; }
    public Image SpeedIcon { get => speedIcon; private set => speedIcon = value; }
    public Image CooldownIcon { get => cooldownIcon; private set => cooldownIcon = value; }
    public Image ArrowIcon { get => arrowIcon; private set => arrowIcon = value; }
    public Image ArrowGlow { get => arrowGlow; private set => arrowGlow = value; }
    
    
    
    public TextMeshProUGUI SpeedText { get => speedText; private set => speedText = value; }
    public TextMeshProUGUI CooldownText { get => cooldownText; private set => cooldownText = value; }
    public TextMeshProUGUI SkillNameText { get => skillNameText; private set => skillNameText = value; }
    public TextMeshProUGUI SkillDescriptionText { get => skillDescriptionText; private set => skillDescriptionText = value; }
    public TextMeshProUGUI SkillElementText { get => skillElementText; private set => skillElementText = value; }
    
    
    
    
    
    

    

    #endregion


    private void Awake()
    {
    
    }
}
