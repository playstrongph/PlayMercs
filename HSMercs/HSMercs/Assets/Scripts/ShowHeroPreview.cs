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
        
        //TODO: Update Hero Skills Display
        UpdateSkillsDisplay();
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
        StopCoroutine(ShowPreview());
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
        //TODO: Show Hero Preview for Enemy Heroes Only?
        
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
    }
    
    /// <summary>
    /// Updates the hero skills on display after a hero is selected
    /// </summary>
    private void UpdateSkillsDisplay()
    {
        var hero = _heroPreview.Hero;
        var heroSkills = _heroPreview.Hero.HeroSkills;
        var player = _heroPreview.Hero.Player;
        var heroAlliance = _heroPreview.Hero.HeroInformation.PlayerAlliance;
        
        heroAlliance.UpdateHeroSkillsOnDisplay(heroSkills,player);

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
