using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroTargetCollider : MonoBehaviour, IHeroTargetCollider
{

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))]
    private Object hero;
    
    public IHeroVisual HeroVisual
    {
        get => hero as IHeroVisual;
        set => hero = value as Object;
    }


}
