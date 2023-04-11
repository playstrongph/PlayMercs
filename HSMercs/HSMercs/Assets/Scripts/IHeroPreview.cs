using UnityEngine;

public interface IHeroPreview
{
    
    /// <summary>
    /// Hero Reference
    /// </summary>
    IHero Hero { get; }

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
    IHeroSkillPreview HeroSkill1Preview { get; }

    /// <summary>
    /// Reference to skill 2 preview graphics
    /// </summary>
    IHeroSkillPreview HeroSkill2Preview { get; }

    /// <summary>
    /// Reference to skill 3 preview graphics
    /// </summary>
    IHeroSkillPreview HeroSkill3Preview { get; }

    IHeroSkillPreview HeroSkill4Preview { get; }

    /// <summary>
    /// Reference to ShowHeroPreview component
    /// </summary>
    IShowHeroPreview ShowHeroPreview { get; }

    /// <summary>
    /// Reference to hero status effects preview transform
    /// </summary>
    Transform StatusEffectPreviewTransform { get; }
    
    
    /// <summary>
    /// HeroPreview's Transform
    /// </summary>
    Transform ThisTransform { get; }
}