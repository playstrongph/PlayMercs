using UnityEngine;

public interface ISkillsPanelVisual
{
    ISkillPanelVisual ThreeSkillPanel { get; }
    ISkillPanelVisual FourSkillPanel { get; }

    GameObject SkillPreviewLocation { get; }
}