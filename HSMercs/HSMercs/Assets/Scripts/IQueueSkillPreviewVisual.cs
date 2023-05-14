using TMPro;
using UnityEngine.UI;

public interface IQueueSkillPreviewVisual
{
    Image RedFrame { get; }
    Image GreenFrame { get; }
    Image BlueFrame { get; }
    Image PreviewImage { get; }
    Image SpeedIcon { get; }
    Image CooldownIcon { get; }
    Image ArrowIcon { get; }
    Image ArrowGlow { get; }
    TextMeshProUGUI SpeedText { get; }
    TextMeshProUGUI CooldownText { get; }
    TextMeshProUGUI SkillNameText { get; }
    TextMeshProUGUI SkillDescriptionText { get; }
    TextMeshProUGUI SkillElementText { get; }
}