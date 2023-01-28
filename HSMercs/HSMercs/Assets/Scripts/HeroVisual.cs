using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroVisual : MonoBehaviour, IHeroVisual
{

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


    #region Properties
    
    /// <summary>
    /// Reference to hero graphics
    /// </summary>
    public IHeroGraphics HeroGraphics
    {
        get => heroGraphic as IHeroGraphics;
        set => heroGraphic = value as Object;
    }
    
    /// <summary>
    /// Reference to hero preview
    /// </summary>
    public IHeroPreview HeroPreview
    {
        get => heroPreview as IHeroPreview;
        set => heroPreview = value as Object;
    }

    

    #endregion
    
   
}
