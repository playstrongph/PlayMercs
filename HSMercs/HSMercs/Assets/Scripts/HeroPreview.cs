using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

public class HeroPreview : MonoBehaviour, IHeroPreview
{
    
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))]private Object hero = null;

    [SerializeField] private Canvas heroPreviewCanvas;
    
    [RequireInterfaceAttribute.RequireInterface(typeof(IHeroGraphicPreview))]
    [SerializeField] private Object heroGraphicPreview;
    
    
    [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillPreview))]
    [SerializeField] private List<Object> heroSkillPreviews = new List<Object>();
    
    [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillPreview))]
    [SerializeField] private Object heroSkill1Preview;
    
    
    [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillPreview))]
    [SerializeField] private Object heroSkill2Preview;

    
    [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillPreview))]
    [SerializeField] private Object heroSkill3Preview;
    
    [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillPreview))]
    [SerializeField] private Object heroSkill4Preview;

    [SerializeField] private Transform statusEffectPreviewTransform;

    

   

    #region Variable Properties
    
    /// <summary>
    /// Set Hero Reference
    /// </summary>
    public IHero Hero => hero as IHero;
    
    
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

    public List<IHeroSkillPreview> HeroSkillPreviews
    {
        get
        {
            var heroSkillPreviewList = new List<IHeroSkillPreview>();
            foreach (var heroSkillPreview in heroSkillPreviews)
            {
                heroSkillPreviewList.Add(heroSkillPreview as IHeroSkillPreview);
            }

            return heroSkillPreviewList;
        }
    }


    /// <summary>
    /// Reference to skill 1 preview graphics
    /// </summary>
    public IHeroSkillPreview HeroSkill1Preview
    {
        get => heroSkill1Preview as IHeroSkillPreview;
        private set => heroSkill1Preview = value as Object;
    }
    
    /// <summary>
    /// Reference to skill 2 preview graphics
    /// </summary>
    public IHeroSkillPreview HeroSkill2Preview
    {
        get => heroSkill2Preview as IHeroSkillPreview;
        private set => heroSkill2Preview = value as Object;
    }
    
    /// <summary>
    /// Reference to skill 3 preview graphics
    /// </summary>
    public IHeroSkillPreview HeroSkill3Preview
    {
        get => heroSkill3Preview as IHeroSkillPreview;
        private set => heroSkill3Preview = value as Object;
    }
    
    /// <summary>
    /// Reference to skill 4 preview graphics
    /// </summary>
    public IHeroSkillPreview HeroSkill4Preview
    {
        get => heroSkill4Preview as IHeroSkillPreview;
        private set => heroSkill4Preview = value as Object;
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
