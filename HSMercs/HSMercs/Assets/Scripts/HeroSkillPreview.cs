using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Class for Skill Visual displays inside the hero preview.  NOT to be
/// confused for skill previews (different)
/// </summary>
public class HeroSkillPreview : MonoBehaviour, IHeroSkillPreview
{


    [Header("SKILL IMAGES")] 
    [SerializeField] private Image skillImage;
    [SerializeField] private Image speedIcon;
    [SerializeField] private Image cooldownIcon;
    
    /// <summary>
    /// All the skill colored frames for fighter, tank, and caster
    /// </summary>
    [Header("SKILL FRAMES")] 
    [SerializeField] private Image greenFrame;
    [SerializeField]private Image redFrame;
    [SerializeField]private Image blueFrame;

    [Header("HERO PREVIEW SKILL TEXTS")] 
    [SerializeField] private TextMeshProUGUI heroPreviewSkillName;
    [SerializeField] private TextMeshProUGUI heroPreviewSkillElement;
    [SerializeField] private TextMeshProUGUI heroPreviewSkillDescription;
    [SerializeField] private TextMeshProUGUI heroPreviewSkillSpeed;
    [SerializeField] private TextMeshProUGUI heroPreviewSkillCooldown;
    
    
    /// <summary>
    /// The hero skill preview image
    /// </summary>
    public Image SkillImage
    {
        get => skillImage;
        set => skillImage = value;
    }
    
    /// <summary>
    /// Reference to speed icon graphic
    /// </summary>
    public Image SpeedIcon
    {
        get => speedIcon;
        set => speedIcon = value;
    }
    
    /// <summary>
    /// Reference to cooldown icon graphic
    /// </summary>
    public Image CooldownIcon
    {
        get => cooldownIcon;
        set => cooldownIcon = value;
    }

    /// <summary>
    /// Tank Skill Preview Frame
    /// </summary>
    public Image RedFrame
    {
        get => redFrame;
        set => redFrame = value;
    }
    
    /// <summary>
    /// Fighter Skill Preview Frame
    /// </summary>
    public Image GreenFrame
    {
        get => greenFrame;
        set => greenFrame = value;
    }
    
    /// <summary>
    /// Caster Skill Preview Frame
    /// </summary>
    public Image BlueFrame
    {
        get => blueFrame;
        set => blueFrame = value;
    }

    /// <summary>
    /// Hero preview skill name text
    /// </summary>
    public TextMeshProUGUI HeroPreviewSkillName
    {
        get => heroPreviewSkillName;
        set => heroPreviewSkillName = value;
    }
    
    /// <summary>
    /// Hero preview skill element text
    /// </summary>
    public TextMeshProUGUI HeroPreviewSkillElement
    {
        get => heroPreviewSkillElement;
        set => heroPreviewSkillElement = value;
    }
    
    /// <summary>
    /// Hero preview skill description text
    /// </summary>
    public TextMeshProUGUI HeroPreviewSkillDescription
    {
        get => heroPreviewSkillDescription;
        set => heroPreviewSkillDescription = value;
    }
    
    /// <summary>
    /// Hero preview skill speed text
    /// </summary>
    public TextMeshProUGUI HeroPreviewSkillSpeed
    {
        get => heroPreviewSkillSpeed;
        set => heroPreviewSkillSpeed = value;
    }
    
    /// <summary>
    /// Hero preview skill cooldown text
    /// </summary>
    public TextMeshProUGUI HeroPreviewSkillCooldown
    {
        get => heroPreviewSkillCooldown;
        set => heroPreviewSkillCooldown = value;
    }
    
    
}
