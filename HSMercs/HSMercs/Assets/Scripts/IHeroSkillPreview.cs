using TMPro;
using UnityEngine.UI;

public interface IHeroSkillPreview
{
    /// <summary>
    /// The hero skill preview image
    /// </summary>
    Image SkillImage { get; set; }

    /// <summary>
    /// Reference to speed icon graphic
    /// </summary>
    Image SpeedIcon { get; set; }

    /// <summary>
    /// Reference to cooldown icon graphic
    /// </summary>
    Image CooldownIcon { get; set; }

    /// <summary>
    /// Fighter Skill Preview Frame
    /// </summary>
    Image GreenFrame { get; set; }

    /// <summary>
    /// Tank Skill Preview Frame
    /// </summary>
    Image RedFrame { get; set; }

    /// <summary>
    /// Caster Skill Preview Frame
    /// </summary>
    Image BlueFrame { get; set; }

    /// <summary>
    /// Hero preview skill name text
    /// </summary>
    TextMeshProUGUI HeroPreviewSkillName { get; set; }

    /// <summary>
    /// Hero preview skill element text
    /// </summary>
    TextMeshProUGUI HeroPreviewSkillElement { get; set; }

    /// <summary>
    /// Hero preview skill description text
    /// </summary>
    TextMeshProUGUI HeroPreviewSkillDescription { get; set; }

    /// <summary>
    /// Hero preview skill speed text
    /// </summary>
    TextMeshProUGUI HeroPreviewSkillSpeed { get; set; }

    /// <summary>
    /// Hero preview skill cooldown text
    /// </summary>
    TextMeshProUGUI HeroPreviewSkillCooldown { get; set; }
}