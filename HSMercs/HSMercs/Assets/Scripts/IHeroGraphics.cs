using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface IHeroGraphics
{
    
    /// <summary>
    /// Hero Reference
    /// </summary>
    IHero Hero { get; }

    /// <summary>
    /// Hero Graphic Canvas
    /// </summary>
    Canvas HeroGraphicCanvas { get; set; }

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
    /// Fighter Hero Graphic
    /// </summary>
    Image GreenHeroGraphic { get; set; }

    /// <summary>
    /// Tank Hero Graphic
    /// </summary>
    Image RedHeroGraphic { get; set; }

    /// <summary>
    /// Caster Hero Graphic
    /// </summary>
    Image BlueHeroGraphic { get; set; }

    /// <summary>
    /// Armor Graphic
    /// </summary>
    Image ArmorGraphic { get; set; }

    Image TargetCrossHairGraphic { get; set; }

    /// <summary>
    /// Attack Text Graphic
    /// </summary>
    TextMeshProUGUI AttackText { get; set; }

    /// <summary>
    /// Health Text Graphic
    /// </summary>
    TextMeshProUGUI HealthText { get; set; }

    /// <summary>
    /// Armor Text Graphic
    /// </summary>
    TextMeshProUGUI ArmorText { get; set; }

    ISetHeroAttackText SetHeroAttackText { get; }

    ISetHeroImage SetHeroImage { get; }

}