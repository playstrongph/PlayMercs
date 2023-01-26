using TMPro;
using UnityEngine.UI;

public interface IStatusEffectVisual
{
    /// <summary>
    /// Returns/Sets the image of the status effect's background frame
    /// </summary>
    Image StatusEffectFrame { get; set; }

    /// <summary>
    /// Returns/Sets the image of the status effect's background Icon 
    /// </summary>
    Image StatusEffectIcon { get; set; }

    TextMeshProUGUI StatusEffectCounters { get; set; }
}