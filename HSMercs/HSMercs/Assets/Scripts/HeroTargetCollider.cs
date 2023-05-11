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
       //Show hero and skill previews
       Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOn();
        
       SelectHeroActions();
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
        Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOff();
    }
    
    /// <summary>
    /// Turns on the hero preview when the mouse re-enters the hero collider
    /// </summary>
    private void OnMouseEnter()
    {
        //Prevents Hero preview appearing during hover or skill targeting
        if (Input.GetMouseButtonDown(0))
            Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOn();
    }
    
    #region TEST
    
    /// <summary>
    /// Actions done when the hero is selected by the player
    /// </summary>
    public void SelectHeroActions()
    {
        //1) Update all hero visuals - information and displayed images and text
        Hero.HeroVisual.UpdateAllHeroVisuals();
      
        //2)Update the hero skills panel - information and displayed images and text
        Hero.HeroSkills.HeroSkillsVisual.UpdateSkillsDisplay();
      
        //3) Show the existing hero skill and its target (if any)
        Hero.HeroSkills.HeroSkillsVisual.ShowSkillAndHeroTarget();
      
        //4) Update the current hero selected (tracked by the player and the other player)
        UpdateCurrentSelectedHero();  
    }
    
    /// <summary>
    /// Update the current hero selected (tracked by the player and the other player)
    /// </summary>
    private void UpdateCurrentSelectedHero()
    {
        Hero.Player.CurrentHeroSelected = Hero;
        Hero.Player.OtherPlayer.CurrentHeroSelected = Hero;
    }


    #endregion


}
