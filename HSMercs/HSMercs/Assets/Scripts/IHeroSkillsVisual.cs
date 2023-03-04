using UnityEngine;

public interface IHeroSkillsVisual
{
    ISkillPanelVisual ThreeSkillPanel { get; }
    ISkillPanelVisual FourSkillPanel { get; }

    GameObject SkillPreviewLocation { get; }
}