using TMPro;
using UnityEngine.UI;

public interface IStatusEffectPreviewVisual
{
    /// <summary>
    /// Returns/Sets the image of the status effect's background frame
    /// </summary>
    Image StatusEffectFrame { get; set; }

    /// <summary>
    /// Returns/Sets the name of the status effect in the hero preview 
    /// </summary>
    TextMeshProUGUI PreviewName { get; set; }

    /// <summary>
    /// Returns/sets the status effect's information in the hero preview
    /// </summary>
    TextMeshProUGUI PreviewInformation { get; set; }
}