using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroVisual : MonoBehaviour, IHeroVisual
{

    #region VARIABLES
    
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

    [SerializeField] private Transform heroStatusEffectsTransform;
    
    #endregion


    #region PROPERTIES
    
    public IHeroGraphics HeroGraphics { get => heroGraphic as IHeroGraphics; set => heroGraphic = value as Object; }
    public IHeroPreview HeroPreview { get => heroPreview as IHeroPreview; set => heroPreview = value as Object; }
    public Transform HeroStatusEffectsTransform { get => heroStatusEffectsTransform; set => heroStatusEffectsTransform = value; }


    #endregion

    #region METHODS

    
    /// <summary>
    /// TODO: Temporary Implementation: Upon clicking hero Update the Following:
    /// 1) Hero and Hero Preview Visuals
    /// 2) SKill and Skill Preview Visuals
    /// </summary>
    public void UpdateAllHeroVisuals()
    {
        UpdateHeroVisuals();
        
        UpdateHeroPreviewVisuals();

        PreviewArmorDisplay();

        UpdateHeroSkillVisuals();
            
        UpdateHeroSkillPreview();
        
        
    }

    private void UpdateHeroVisuals()
    {
        
        var hero = HeroGraphics.Hero;
        var attack = hero.HeroStats.Attack;
        var health = hero.HeroStats.Health;
        var armor = hero.HeroStats.Armor;

        //Load Health Text
        hero.HeroVisual.HeroGraphics.SetHeroHealthText.SetValue(health);
      
        //Load Attack Text
        hero.HeroVisual.HeroGraphics.SetHeroAttackText.SetValue(attack);
      
        //Load Armor Text
        hero.HeroVisual.HeroGraphics.SetHeroArmorText.SetValue(armor);
        
        
    }

    private void UpdateHeroPreviewVisuals()
    {
        var hero = HeroGraphics.Hero;
        
        //Previews and Skill Previews
        HeroPreview.HeroGraphicPreview.PreviewAttackText.text = hero.HeroStats.Attack.ToString();
        HeroPreview.HeroGraphicPreview.PreviewHealthText.text = hero.HeroStats.Health.ToString();
        HeroPreview.HeroGraphicPreview.PreviewNameText.text = hero.HeroInformation.HeroName;
    }

    private void PreviewArmorDisplay()
    {
        var hero = HeroGraphics.Hero;
        var armor = hero.HeroStats.Armor;
        
        HeroPreview.HeroGraphicPreview.PreviewArmorText.text = hero.HeroStats.Armor.ToString();

        if (armor > 0)
        {
            HeroPreview.HeroGraphicPreview.ArmorImage.enabled = true;
            HeroPreview.HeroGraphicPreview.PreviewArmorText.enabled = true;
        }
        else
        {
            HeroPreview.HeroGraphicPreview.ArmorImage.enabled = false;
            HeroPreview.HeroGraphicPreview.PreviewArmorText.enabled = false;
        }

    }
    
    private void UpdateHeroSkillPreview( )
    {
        var hero = HeroGraphics.Hero;
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
    
    private void UpdateHeroSkillVisuals( )
    {
        var hero = HeroGraphics.Hero;
        var allHeroSkills = hero.HeroSkills.AllHeroSkills;
        
        //This indicates the actual number of skills the hero has
        var skillAssetsCount = hero.HeroInformation.HeroAsset.SkillAssets.Count;
        
        
        //Use skillAssetCount here as it is the ACTUAL skill count the hero has
        //However, the skillAsset information is NOT the latest info on the status of the skill
        //Take the skill information from skill attributes
        for (var i = 0; i < skillAssetsCount; i++) 
        {
            
            var heroSkill = allHeroSkills[i];
            
            //This is the skill speed
            heroSkill.SkillVisual.SkillGraphics.SkillReadyText.text = heroSkill.SkillAttributes.SkillSpeed.ToString();
      
            //This is the skill cooldown
            heroSkill.SkillVisual.SkillGraphics.SkillNotReadyText.text = heroSkill.SkillAttributes.SkillCooldown.ToString();
            
            //Skill Type Visuals
            heroSkill.SkillAttributes.SkillType.LoadSkillTypeVisuals(heroSkill);
            
            //Skill Enabled Visuals
            heroSkill.SkillAttributes.SkillEnableStatus.SkillDisabledVisuals(heroSkill);
        }
    }
    
    

    #endregion
    
   
}
