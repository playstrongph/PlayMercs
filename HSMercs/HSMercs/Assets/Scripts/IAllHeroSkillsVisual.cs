using UnityEngine;

public interface IAllHeroSkillsVisual
{
    ISkillPanelVisual ThreeSkillPanel { get; }
    ISkillPanelVisual FourSkillPanel { get; }

    GameObject SkillPreviewLocation { get; }
}