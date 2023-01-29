using UnityEngine;

public interface ISkillTargetCollider
{
    GameObject TargetArrow { get; }
    LineRenderer TargetLine { get; }
    Canvas TargetCanvas { get; }
    
    ISelectDragTarget SelectDragTarget { get;}
}