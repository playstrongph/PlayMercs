using System.Collections.Generic;
using UnityEngine;

public interface IHeroSkills
{
    ISkillPanelVisual ThreeSkillPanel { get; }

    ISkillPanelVisual FourSkillPanel { get; }
    List<ISkill> AllHeroSkills { get; }

    GameObject ThisGameObject { get; }
    
    ISkill SelectedSkill { get; set; }
    IHero SelectedTarget { get; set; }
}