using System.Collections.Generic;
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
    /// HeroSkillPreview list
    /// </summary>
    List<IHeroSkillPreview> HeroSkillPreviews { get; }

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