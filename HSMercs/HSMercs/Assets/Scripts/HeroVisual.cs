using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroVisual : MonoBehaviour, IHeroVisual
{

    #region VARIABLES
    
    /// <summary>
    /// Reference to hero graphics
    /// </summary>
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroGraphics))]
    private Object heroGraphic;
    
    /// <summary>
    /// Reference to hero preview graphics
    /// </summary>
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreview))]
    private Object heroPreview;

    [SerializeField] private Transform heroStatusEffectsTransform;
    
    #endregion


    #region PROPERTIES
    
    public IHeroGraphics HeroGraphics { get => heroGraphic as IHeroGraphics; set => heroGraphic = value as Object; }
    public IHeroPreview HeroPreview { get => heroPreview as IHeroPreview; set => heroPreview = value as Object; }
    public Transform HeroStatusEffectsTransform { get => heroStatusEffectsTransform; set => heroStatusEffectsTransform = value; }


    #endregion
    
   
}
