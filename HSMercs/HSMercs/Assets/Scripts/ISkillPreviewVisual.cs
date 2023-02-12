using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface ISkillPreviewVisual
{
    Image RedFrame { get; }
    Image GreenFrame { get; }
    Image BlueFrame { get; }
    Image PreviewImage { get; }
    Image SpeedIcon { get; }
    Image CooldownIcon { get; }
    TextMeshProUGUI SpeedText { get; }
    TextMeshProUGUI CooldownText { get; }
    TextMeshProUGUI SkillNameText { get; }
    TextMeshProUGUI SkillDescriptionText { get; }
    TextMeshProUGUI SkillElementText { get; }
    Canvas PreviewCanvas { get; }

    IShowSkillPreview ShowSkillPreview { get; }
}