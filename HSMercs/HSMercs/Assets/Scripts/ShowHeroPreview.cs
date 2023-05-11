using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHeroPreview : MonoBehaviour, IShowHeroPreview
{
    #region VARIABLES
    
    [SerializeField] private float displayDelay = 0.5f;

    private IHeroPreview _heroPreview;
    
    //This prevents turning on hero preview during skill targeting
    private bool _enablePreview = false;
    
    //TEST 
    private Coroutine _delayCoroutine = null;

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
        
        //Stop coroutine if running previously
        if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
        
        _delayCoroutine = StartCoroutine(ShowPreview());
    }
    
    /// <summary>
    /// Show hero preview on Mouse Enter but after mousedown
    /// Prevents hero preview appearing during skill targeting
    /// </summary>
    public void TurnOnMouseEnter()
    {
        //Stop coroutine if running previously
        if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
        
        _delayCoroutine = StartCoroutine(ShowPreview());
    }
    
    /// <summary>
    /// Hides Hero Preview
    /// </summary>
    public void TurnOff()
    {
        _enablePreview = false;
        _heroPreview.HeroPreviewCanvas.enabled = false;
        
        //Stop coroutine if running previously
        if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
    }
    
    /// <summary>
    /// Turns off upon mouse exit but doesn't change the enable state
    /// Prevents hero preview appearing during skill targeting
    /// </summary>
    public void TurnOffMouseExit()
    {
        //_enablePreview = false;
        _heroPreview.HeroPreviewCanvas.enabled = false;
        
        //Stop coroutine if running previously
        if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
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

            PreviewArmorDisplay(hero);
            
            UpdateHeroSkillPreview(hero);
        }

        _delayCoroutine = null;
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
    
    
    /// <summary>
    /// Update Hero Skill Previews with the lastest information and visuals
    /// </summary>
    private void UpdateHeroSkillPreview(IHero hero)
    {

        var allHeroSkills = hero.HeroSkills.AllHeroSkills;
        var heroSkillPreviews = hero.HeroVisual.HeroPreview.HeroSkillPreviews;
        //This indicates the actual number of skills the hero has
        var skillAssetsCount = hero.HeroInformation.HeroAsset.SkillAssets.Count;
        
        
        //Use skillAssetCount here as it is the ACTUAL skill count the hero has
        //However, the skillAsset information is NOT the latest info on the status of the skill
        //Take the skill information from skill attributes
        for (int i = 0; i < skillAssetsCount; i++)
        {
            var skillPreview = heroSkillPreviews[i];
            var heroSkill = allHeroSkills[i];

            skillPreview.HeroPreviewSkillCooldown.text = heroSkill.SkillAttributes.SkillCooldown.ToString();
            skillPreview.HeroPreviewSkillSpeed.text = heroSkill.SkillAttributes.SkillSpeed.ToString();
        }
        
    }

    #endregion

}
