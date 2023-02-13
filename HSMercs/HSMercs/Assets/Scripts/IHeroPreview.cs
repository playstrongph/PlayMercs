using UnityEngine;

public interface IHeroPreview
{
    
    /// <summary>
    /// Reference to the hero preview canvas
    /// </summary>
    Canvas HeroPreviewCanvas { get; }

    /// <summary>
    /// Reference to hero preview graphics
    /// </summary>
    IHeroGraphicPreview HeroGraphicPreview { get; }

    /// <summary>
    /// Reference to skill 1 preview graphics
    /// </summary>
    IHeroSkillPreview HeroSkillPreview1 { get; }

    /// <summary>
    /// Reference to skill 2 preview graphics
    /// </summary>
    IHeroSkillPreview HeroSkillPreview2 { get; }

    /// <summary>
    /// Reference to skill 3 preview graphics
    /// </summary>
    IHeroSkillPreview HeroSkillPreview3 { get; }

    /// <summary>
    /// Reference to ShowHeroPreview component
    /// </summary>
    IShowHeroPreview ShowHeroPreview { get; }

    /// <summary>
    /// Reference to hero status effects preview transform
    /// </summary>
    Transform StatusEffectPreviewTransform { get; }
}