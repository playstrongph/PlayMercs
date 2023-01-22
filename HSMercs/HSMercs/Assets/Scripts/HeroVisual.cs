using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroVisual : MonoBehaviour, IHeroVisual
{

    /// <summary>
    /// Reference to hero preview graphics
    /// </summary>
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroGraphicPreview))]
    private Object heroPreviewGraphic;
    
    /// <summary>
    /// Hero Preview Graphic - get only
    /// </summary>
    public IHeroGraphicPreview HeroGraphicPreview
    {
        get => heroPreviewGraphic as IHeroGraphicPreview;
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
