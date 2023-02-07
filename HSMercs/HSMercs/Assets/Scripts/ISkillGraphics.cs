using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface ISkillGraphics
{
    Canvas SkillCanvas { get; }
    Image SkillReadyFrame { get; }
    Image SkillNotReadyFrame { get; }
    Image PassiveSkillFrame { get; }
    Image SkillReadyGraphic { get; }
    Image SkillNotReadyGraphic { get; }
    Image PassiveSkillGraphic { get; }
    Image TargetArrow { get; }
    Image CrossHairGraphic { get; }
    
    TextMeshProUGUI SkillReadyText { get; }
    TextMeshProUGUI SkillNotReadyText { get; }
}