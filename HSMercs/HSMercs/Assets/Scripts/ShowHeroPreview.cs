using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHeroPreview : MonoBehaviour, IShowHeroPreview
{
    #region VARIABLES
    
    [SerializeField] private float displayDelay = 0.5f;

    private IHeroPreview _heroPreview;
    
    private bool _enablePreview = false;

    #endregion

    #region METHODS

    private void Awake()
    {
        _heroPreview = GetComponent<IHeroPreview>();
    }

    /// <summary>
    /// Shows Hero Preview
    /// </summary>
    public void TurnOn()
    {
        _enablePreview = true;
        StartCoroutine(ShowPreview());
    }
    
    /// <summary>
    /// Show hero preview on Mouse Enter but after mousedown
    /// </summary>
    public void TurnOnMouseEnter()
    {
        StartCoroutine(ShowPreview());
    }
    
    /// <summary>
    /// Hides Hero Preview
    /// </summary>
    public void TurnOff()
    {
        _enablePreview = false;
        
        _heroPreview.HeroPreviewCanvas.enabled = false;
    }
    
    /// <summary>
    /// Turns off upon mouse exit but doesn't change the enable state
    /// </summary>
    public void TurnOffMouseExit()
    {
        
        _heroPreview.HeroPreviewCanvas.enabled = false;
    }

    /// <summary>
    /// Waits for a delay before checking if preview is enabled
    /// </summary>
    /// <returns></returns>
    private IEnumerator ShowPreview()
    {
        yield return new WaitForSeconds(displayDelay);
        if (_enablePreview)
        {
            var hero = _heroPreview.Hero;
            
            _heroPreview.HeroPreviewCanvas.enabled = true;

            _heroPreview.HeroGraphicPreview.PreviewAttackText.text = hero.HeroStats.Attack.ToString();
            _heroPreview.HeroGraphicPreview.PreviewHealthText.text = hero.HeroStats.Health.ToString();
            _heroPreview.HeroGraphicPreview.PreviewNameText.text = hero.HeroInformation.HeroName;
            
            //TODO: Change to Race
            _heroPreview.HeroGraphicPreview.PreviewRaceText.text = hero.HeroInformation.HeroClass.ClassName;
            
            PreviewArmorDisplay(hero);


        }
    }

    private void PreviewArmorDisplay(IHero hero)
    {
        var heroPreview = hero.HeroVisual.HeroPreview;
        var armor = hero.HeroStats.Armor;
        
        heroPreview.HeroGraphicPreview.PreviewArmorText.text = hero.HeroStats.Armor.ToString();

        if (armor > 0)
        {
            heroPreview.HeroGraphicPreview.ArmorImage.enabled = true;
            heroPreview.HeroGraphicPreview.PreviewArmorText.enabled = true;
        }
        else
        {
            heroPreview.HeroGraphicPreview.ArmorImage.enabled = false;
            heroPreview.HeroGraphicPreview.PreviewArmorText.enabled = false;
        }



    }

    #endregion

}
