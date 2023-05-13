using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface ISkillPreviewTargets
{
    List<IHeroGraphicPreview> HeroTargetPreviews { get; }
    GridLayoutGroup HeroesGrid { get; set; }
    Canvas Canvas { get; set; }

    /// <summary>
    /// Changes the grid setup based on the number of heroes - 1 or many;
    /// </summary>
    /// <param name="heroTargets"></param>
    void UpdateGridSetup(List<IHero> heroTargets);
}