using UnityEngine;
using UnityEngine.UI;

public interface ISkillPanelVisual
{
    Image GreenPanel { get; }
    Image BluePanel { get; }
    Image RedPanel { get; }
    Transform SkillGridTransform { get; }
    
    Canvas SkillPanelCanvas { get; }

    GameObject ThisGameObject { get; }
}