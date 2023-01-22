using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface IHeroGraphicPreview
{

    /// <summary>
    /// The hero Preview Canvas
    /// </summary>
    Canvas HeroPreviewCanvas { get; set; }

    /// <summary>
    /// Fighter Preview Frame
    /// </summary>
    Image GreenFrame { get; set; }

    /// <summary>
    /// Tank Preview Frame
    /// </summary>
    Image RedFrame { get; set; }

    /// <summary>
    /// Caster Preview Frame
    /// </summary>
    Image BlueFrame { get; set; }

    /// <summary>
    /// Fighter Preview Hero Graphic
    /// </summary>
    Image GreenHeroGraphic { get; set; }

    /// <summary>
    /// Tank Preview Hero Graphic
    /// </summary>
    Image RedHeroGraphic { get; set; }

    /// <summary>
    /// Caster Preview Hero Graphic
    /// </summary>
    Image BlueHeroGraphic { get; set; }

    /// <summary>
    /// Hero Name that appears in hero preview
    /// </summary>
    TextMeshProUGUI PreviewNameText { get; set; }

    /// <summary>
    /// Hero Race that appears in hero preview
    /// </summary>
    TextMeshProUGUI PreviewRaceText { get; set; }

    /// <summary>
    /// Hero attack text that appears in hero preview
    /// </summary>
    TextMeshProUGUI PreviewAttackText { get; set; }

    /// <summary>
    /// Hero health text that appears in hero preview
    /// </summary>
    TextMeshProUGUI PreviewHealthText { get; set; }
}