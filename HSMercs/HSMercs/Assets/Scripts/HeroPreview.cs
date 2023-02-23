using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class HeroPreview : MonoBehaviour, IHeroPreview
{

    [SerializeField] private Canvas heroPreviewCanvas;
    
    [RequireInterfaceAttribute.RequireInterface(typeof(IHeroGraphicPreview))]
    [SerializeField] private Object heroGraphicPreview;
    
    [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillPreview))]
    [SerializeField] private Object heroSkillPreview1;
    
    [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillPreview))]
    [SerializeField] private Object heroSkillPreview2;

    [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillPreview))]
    [SerializeField] private Object heroSkillPreview3;

    [SerializeField] private Transform statusEffectPreviewTransform;

   

    #region Variable Properties
    
    /// <summary>
    /// Reference to the hero preview canvas
    /// </summary>
    public Canvas HeroPreviewCanvas { get => heroPreviewCanvas; private set => heroPreviewCanvas = value; }

    /// <summary>
    /// Reference to hero preview graphics
    /// </summary>
    public IHeroGraphicPreview HeroGraphicPreview
    {
        get => heroGraphicPreview as IHeroGraphicPreview;
        private set => heroGraphicPreview = value as Object;
    }
    
    /// <summary>
    /// Reference to skill 1 preview graphics
    /// </summary>
    public IHeroSkillPreview HeroSkillPreview1
    {
        get => heroSkillPreview1 as IHeroSkillPreview;
        private set => heroSkillPreview1 = value as Object;
    }
    
    /// <summary>
    /// Reference to skill 2 preview graphics
    /// </summary>
    public IHeroSkillPreview HeroSkillPreview2
    {
        get => heroSkillPreview2 as IHeroSkillPreview;
        private set => heroSkillPreview2 = value as Object;
    }
    
    /// <summary>
    /// Reference to skill 3 preview graphics
    /// </summary>
    public IHeroSkillPreview HeroSkillPreview3
    {
        get => heroSkillPreview3 as IHeroSkillPreview;
        private set => heroSkillPreview3 = value as Object;
    }
    
    /// <summary>
    /// Reference to Show Hero Preview
    /// </summary>
    public IShowHeroPreview ShowHeroPreview { get; private set; }
    
    public Transform StatusEffectPreviewTransform { get => statusEffectPreviewTransform; set => statusEffectPreviewTransform = value; }

    /// <summary>
    /// Hero Preview's Transform
    /// </summary>
    public Transform ThisTransform { get; private set; }

    #endregion

    private void Awake()
    {
        ShowHeroPreview = GetComponent<IShowHeroPreview>();
        ThisTransform = this.gameObject.transform;
    }
}
