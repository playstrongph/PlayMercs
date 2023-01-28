using TMPro;
using UnityEngine.UI;

public interface ISkillGraphics
{
    Image SkillReadyFrame { get; }
    Image SkillNotReadyFrame { get; }
    Image PassiveSkillFrame { get; }
    Image SkillReadyGraphic { get; }
    Image SkillNotReadyGraphic { get; }
    Image PassiveSkillGraphic { get; }
    Image TargetArrow { get; }
    TextMeshProUGUI SkillReadyText { get; }
    TextMeshProUGUI SkillNotReadyText { get; }
}