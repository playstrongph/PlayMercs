using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroGraphics : MonoBehaviour, IHeroGraphics
{

    #region VARIABLES

    /// <summary>
    /// The hero Preview Canvas
    /// </summary>
    [Header("GRAPHIC CANVAS")] 
    [SerializeField] private Canvas heroGraphicCanvas;
    
    /// <summary>
    /// All the hero colored frames for fighter, tank, and caster
    /// </summary>
    [Header("HERO FRAMES")] 
    [SerializeField] private Image greenFrame;
    [SerializeField]private Image redFrame;
    [SerializeField]private Image blueFrame;
    
    /// <summary>
    /// All the hero graphic images for fighter, tank, and caster
    /// </summary>
    [Header("HERO GRAPHICS")] 
    [SerializeField] private Image greenHeroGraphic;
    [SerializeField]private Image redHeroGraphic;
    [SerializeField]private Image blueHeroGraphic;
    [SerializeField]private Image armorGraphic;
    [SerializeField]private Image targetCrossHairGraphic;

    /// <summary>
    /// Hero preview texts
    /// </summary>
    [Header("HERO GRAPHIC TEXTS")] 
    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI armorText;
    
    #endregion

    #region SERIALIZED VARIABLE PROPERTIES

    /// <summary>
    /// Hero Graphic Canvas
    /// </summary>
    public Canvas HeroGraphicCanvas
    {
        get => heroGraphicCanvas;
        set => heroGraphicCanvas = value;
    }
    
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
    /// Tank Hero Graphic
    /// </summary>
    public Image RedHeroGraphic
    {
        get => redHeroGraphic;
        set => redHeroGraphic = value;
    }
    
    /// <summary>
    /// Fighter Hero Graphic
    /// </summary>
    public Image GreenHeroGraphic
    {
        get => greenHeroGraphic;
        set => greenHeroGraphic = value;
    }
    
    /// <summary>
    /// Caster Hero Graphic
    /// </summary>
    public Image BlueHeroGraphic
    {
        get => blueHeroGraphic;
        set => blueHeroGraphic = value;
    }
    
    /// <summary>
    /// Armor Graphic
    /// </summary>
    public Image ArmorGraphic
    {
        get => armorGraphic;
        set => armorGraphic = value;
    }
    
    public Image TargetCrossHairGraphic
    {
        get => targetCrossHairGraphic;
        set => targetCrossHairGraphic = value;
    }
    
    /// <summary>
    /// Attack Text Graphic
    /// </summary>
    public TextMeshProUGUI AttackText
    {
        get => attackText;
        set => attackText = value;
    }
    
    /// <summary>
    /// Health Text Graphic
    /// </summary>
    public TextMeshProUGUI HealthText
    {
        get => healthText;
        set => healthText = value;
    }
    
    /// <summary>
    /// Armor Text Graphic
    /// </summary>
    public TextMeshProUGUI ArmorText
    {
        get => armorText;
        set => armorText = value;
    }

    #endregion


}
