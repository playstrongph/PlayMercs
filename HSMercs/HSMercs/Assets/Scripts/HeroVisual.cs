using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroVisual : MonoBehaviour, IHeroVisual
{
   
    /// <summary>
    /// Reference to hero preview canvas
    /// </summary>
    [SerializeField] private Canvas previewCanvas;
    
    /// <summary>
    /// Reference to hero preview graphics
    /// </summary>
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewGraphic))]
    private Object heroPreviewGraphic;
    
    
    public Canvas PreviewCanvas
    {
        get => previewCanvas;
        set => previewCanvas = value;
    }

    public IHeroPreviewGraphic HeroPreviewGraphic
    {
        get => heroPreviewGraphic as IHeroPreviewGraphic;
        set => heroPreviewGraphic = value as Object;
    }




}
