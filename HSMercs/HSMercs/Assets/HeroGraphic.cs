using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroGraphic : MonoBehaviour
{
    
    /// <summary>
    /// All the hero colored frames for fighter, tank, and caster
    /// </summary>
    [Header("HERO FRAMES")] 
    [SerializeField] private Image greenFrame;
    [SerializeField]private Image redFrame;
    [SerializeField]private Image blueFrame;
    
    /// <summary>
    /// All the hero graphic images for fighter, tank, and caster
    /// </summary>
    [Header("HERO GRAPHIC")] 
    [SerializeField] private Image greenHeroGraphic;
    [SerializeField]private Image redHeroGraphic;
    [SerializeField]private Image blueHeroGraphic;
    
    
}
