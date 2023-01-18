using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Class for Skill Visual displays inside the hero preview.  NOT to be
/// confused for skill previews (different)
/// </summary>
public class HeroPreviewSkill : MonoBehaviour
{


    [Header("SKILL IMAGE")] 
    [SerializeField] private Image skillImage;
    
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
    
    /// <summary>
    /// The hero skill preview image
    /// </summary>
    public Image SkillImage
    {
        get => skillImage;
        set => skillImage = value;
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
    
    
}
