using UnityEngine;

public interface IHeroVisual
{
    
    /// <summary>
    /// Returns hero graphic reference for changing hero visuals
    /// </summary>
    IHeroGraphics HeroGraphics { get; }

    /// <summary>
    /// Reference to hero preview
    /// </summary>
    IHeroPreview HeroPreview { get; }

    void UpdateAllHeroVisuals();


}