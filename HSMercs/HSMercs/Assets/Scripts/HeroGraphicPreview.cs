﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroGraphicPreview : MonoBehaviour, IHeroGraphicPreview
{

    #region VARIABLES
    
    /// <summary>
    /// All the hero colored frames for fighter, tank, and caster
    /// </summary>
    [Header("HERO FRAMES")] 
    [SerializeField] private Image greenFrame;
    [SerializeField]private Image redFrame;
    [SerializeField]private Image blueFrame;
    [SerializeField]private Image armorImage;
    
    /// <summary>
    /// All the hero graphic images for fighter, tank, and caster
    /// </summary>
    [Header("HERO GRAPHIC")] 
    [SerializeField] private Image greenHeroGraphic;
    [SerializeField]private Image redHeroGraphic;
    [SerializeField]private Image blueHeroGraphic;
    
    /// <summary>
    /// Hero preview texts
    /// </summary>
    [Header("HERO PREVIEW TEXTS")] 
    [SerializeField] private TextMeshProUGUI previewNameText;
    [SerializeField] private TextMeshProUGUI previewRaceText;
    [SerializeField] private TextMeshProUGUI previewAttackText;
    [SerializeField] private TextMeshProUGUI previewHealthText;
    [SerializeField] private TextMeshProUGUI previewArmorText;
        
    #endregion
    
    #region SERIALIZED VARIABLES PROPERTIES

    /// <summary>
    /// Tank Preview Frame
    /// </summary>
    public Image RedFrame
    {
        get => redFrame;
        set => redFrame = value;
    }
    
    /// <summary>
    /// Fighter Preview Frame
    /// </summary>
    public Image GreenFrame
    {
        get => greenFrame;
        set => greenFrame = value;
    }
    
    /// <summary>
    /// Caster Preview Frame
    /// </summary>
    public Image BlueFrame
    {
        get => blueFrame;
        set => blueFrame = value;
    }
    
    /// <summary>
    /// Armor Image
    /// </summary>
    public Image ArmorImage
    {
        get => armorImage;
        set => armorImage = value;
    }
    
    /// <summary>
    /// Tank Preview Hero Graphic
    /// </summary>
    public Image RedHeroGraphic
    {
        get => redHeroGraphic;
        set => redHeroGraphic = value;
    }
    
    /// <summary>
    /// Fighter Preview Hero Graphic
    /// </summary>
    public Image GreenHeroGraphic
    {
        get => greenHeroGraphic;
        set => greenHeroGraphic = value;
    }
    
    /// <summary>
    /// Caster Preview Hero Graphic
    /// </summary>
    public Image BlueHeroGraphic
    {
        get => blueHeroGraphic;
        set => blueHeroGraphic = value;
    }

   
    /// <summary>
    /// Hero Name that appears in hero preview
    /// </summary>
    public TextMeshProUGUI PreviewNameText
    {
        get => previewNameText;
        set => previewNameText = value;
    }
    
    /// <summary>
    /// Hero Race that appears in hero preview
    /// </summary>
    public TextMeshProUGUI PreviewRaceText
    {
        get => previewRaceText;
        set => previewRaceText = value;
    }
    
    
    /// <summary>
    /// Hero attack text that appears in hero preview
    /// </summary>
    public TextMeshProUGUI PreviewAttackText
    {
        get => previewAttackText;
        set => previewAttackText = value;
    }
    
    
    /// <summary>
    /// Hero health text that appears in hero preview
    /// </summary>
    public TextMeshProUGUI PreviewHealthText
    {
        get => previewHealthText;
        set => previewHealthText = value;
    }
    
    /// <summary>
    /// Hero preview armor text
    /// </summary>
    public TextMeshProUGUI PreviewArmorText
    {
        get => previewArmorText;
        set => previewArmorText = value;
    }


    #endregion
    
    
   






    

}
