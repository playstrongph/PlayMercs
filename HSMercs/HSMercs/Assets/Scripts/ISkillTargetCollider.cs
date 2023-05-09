using UnityEngine;

public interface ISkillTargetCollider
{

    ISkill Skill { get; }
    GameObject TargetArrow { get; }

    ITargetNodes TargetNodes { get; }
  
    Canvas TargetCanvas { get; }
    
    ISkillTargeting SkillTargeting { get;}

    IDraggable Draggable { get; }
    
    ISkillTargets SkillTargets { get; set; }

    IManualSelectTarget ManualSelectTarget { get; }
    
    ISkillTargetDisplay SkillTargetDisplay { get; set; }
}