using UnityEngine;

public interface IHeroVisual
{
    
    /// <summary>
    /// Returns hero graphic reference for changing hero visuals
    /// </summary>
    IHeroGraphic HeroGraphic { get; }

    /// <summary>
    /// Reference to hero preview
    /// </summary>
    IHeroPreview HeroPreview { get; }

   
}