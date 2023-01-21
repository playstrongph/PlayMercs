using UnityEngine;

public interface IHeroVisual
{   
    /// <summary>
    /// Returns hero preview graphic reference for changing hero preview visuals
    /// </summary>
    IHeroPreviewGraphic HeroPreviewGraphic { get; }
    
    /// <summary>
    /// Returns hero graphic reference for changing hero visuals
    /// </summary>
    IHeroGraphic HeroGraphic { get; }
}