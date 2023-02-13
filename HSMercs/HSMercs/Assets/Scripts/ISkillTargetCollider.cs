using UnityEngine;

public interface ISkillTargetCollider
{

    ISkill Skill { get; }
    GameObject TargetArrow { get; }

    ITargetNodes TargetNodes { get; }
  
    Canvas TargetCanvas { get; }
    
    IDrawTargetLineAndArrow DrawTargetLineAndArrow { get;}

    IDraggable Draggable { get; }
}