using UnityEngine;

public interface IHeroVisual
{   
    /// <summary>
    /// Returns hero preview graphic reference for changing hero preview visuals
    /// </summary>
    IHeroGraphicPreview HeroGraphicPreview { get; }
    
    /// <summary>
    /// Returns hero graphic reference for changing hero visuals
    /// </summary>
    IHeroGraphic HeroGraphic { get; }
}