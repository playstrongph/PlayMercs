using UnityEngine;

public interface ISkillTargetCollider
{

    ISkill Skill { get; }
    GameObject TargetArrow { get; }

    ITargetNodes TargetNodes { get; }
  
    Canvas TargetCanvas { get; }
    
    ISelectDragTarget SelectDragTarget { get;}

    IDraggable Draggable { get; }
}