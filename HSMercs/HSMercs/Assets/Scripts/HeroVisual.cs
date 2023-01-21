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

}
