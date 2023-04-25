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
      
      //TODO: Update Hero Visuals as well
      //TODO: Update Hero Skills Visual as well
      
      //TEST
      Hero.HeroVisual.UpdateAllHeroVisuals();
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
