using UnityEngine;

public interface ISkillTargetCollider
{
    GameObject TargetArrow { get; }

    GameObject TargetNode { get; }
    LineRenderer TargetLine { get; }
    Canvas TargetCanvas { get; }
    
    ISelectDragTarget SelectDragTarget { get;}

    IDraggable Draggable { get; }
}