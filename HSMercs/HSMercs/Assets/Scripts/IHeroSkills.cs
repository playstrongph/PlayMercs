using UnityEngine;

public interface IHeroSkills
{
    ISkillPanelVisual ThreeSkillPanelVisual { get; }

    GameObject ThisGameObject { get; }
}