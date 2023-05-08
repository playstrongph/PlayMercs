using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// All mouse actions are done in this class
/// </summary>
public class HeroTargetCollider : MonoBehaviour, IHeroTargetCollider
{

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))]
    private Object hero;
    
    public IHero Hero
    {
        get => hero as IHero;
        set => hero = value as Object;
    }
    
    /// <summary>
    /// 1) Show hero preview and its skills after a delay
    /// 2) Update all hero visuals - information and displayed images and text
    /// 3) Update the hero skills panel - information and displayed images and text
    /// 4) Show the existing hero skill and its target (if any)
    /// 5) Update the current hero selected (tracked by the player and the other player)
    /// </summary>
    private void OnMouseDown()
    {
      //1) Show hero preview and its skills after a delay  
      Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOn();
      
      //2) Update all hero visuals - information and displayed images and text
      Hero.HeroVisual.UpdateAllHeroVisuals();
      
      //3)Update the hero skills panel - information and displayed images and text
      Hero.HeroSkills.HeroSkillsVisual.UpdateSkillsDisplay();
      
      //4) Show the existing hero skill and its target (if any)
      Hero.HeroSkills.HeroSkillsVisual.ShowSkillAndHeroTarget();
      
      //5) Update the current hero selected (tracked by the player and the other player)
      UpdateCurrentSelectedHero();
    }
        
    /// <summary>
    /// Turns off the hero preview upon mouse up
    /// </summary>
    private void OnMouseUp()
    {
        Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOff();
    }
    
    /// <summary>
    /// Turns off the hero preview when the mouse exits the hero collider
    /// </summary>
    private void OnMouseExit()
    {
        Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOffMouseExit();
    }
    
    /// <summary>
    /// Turns on the hero preview when the mouse re-enters the hero collider
    /// </summary>
    private void OnMouseEnter()
    {
        Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOnMouseEnter();
    }
    
    
    /// <summary>
    /// Update the current hero selected (tracked by the player and the other player)
    /// </summary>
    private void UpdateCurrentSelectedHero()
    {
        Hero.Player.CurrentHeroSelected = Hero;
        Hero.Player.OtherPlayer.CurrentHeroSelected = Hero;
    }

    #region TEST
    
    /// <summary>
    /// Actions done when the hero is selected by the player
    /// </summary>
    public void SelectHeroActions()
    {
        //1) Show hero preview and its skills after a delay  
        //Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOn();
      
        //2) Update all hero visuals - information and displayed images and text
        Hero.HeroVisual.UpdateAllHeroVisuals();
      
        //3)Update the hero skills panel - information and displayed images and text
        Hero.HeroSkills.HeroSkillsVisual.UpdateSkillsDisplay();
      
        //4) Show the existing hero skill and its target (if any)
        Hero.HeroSkills.HeroSkillsVisual.ShowSkillAndHeroTarget();
      
        //5) Update the current hero selected (tracked by the player and the other player)
        UpdateCurrentSelectedHero();  
    }


    #endregion


}
