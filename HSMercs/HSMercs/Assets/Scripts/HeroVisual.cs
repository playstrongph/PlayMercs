using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroVisual : MonoBehaviour, IHeroVisual
{

    /// <summary>
    /// Reference to hero preview graphics
    /// </summary>
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewGraphic))]
    private Object heroPreviewGraphic;
    
    /// <summary>
    /// Hero Preview Graphic - get only
    /// </summary>
    public IHeroPreviewGraphic HeroPreviewGraphic
    {
        get => heroPreviewGraphic as IHeroPreviewGraphic;
        set => heroPreviewGraphic = value as Object;
    }
    
    /// <summary>
    /// Reference to hero graphics
    /// </summary>
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroGraphic))]
    private Object heroGraphic;
    
    /// <summary>
    /// Hero Graphic - get only
    /// </summary>
    public IHeroGraphic HeroGraphic
    {
        get => heroGraphic as IHeroGraphic;
        set => heroGraphic = value as Object;
    }

}
