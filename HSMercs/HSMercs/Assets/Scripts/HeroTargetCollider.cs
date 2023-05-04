using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is the class where the mouse actions should be assigned to
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
    
    private void OnMouseDown()
    {
      Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOn();

      Hero.HeroVisual.UpdateAllHeroVisuals();
      
      Hero.HeroSkills.HeroSkillsVisual.UpdateSkillsDisplay();
      
      //TEST
      Hero.HeroSkills.HeroSkillsVisual.ShowSkillAndHeroTarget();
      
      
    }
        
    private void OnMouseUp()
    {
        Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOff();
    }
    
    private void OnMouseExit()
    {
        Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOffMouseExit();
    }
    
    private void OnMouseEnter()
    {
        Hero.HeroVisual.HeroPreview.ShowHeroPreview.TurnOnMouseEnter();
    }


}
