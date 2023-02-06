using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour, IHero
{
    #region VARIABLES

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))]
    private Object heroVisual;

    #endregion


    #region PROPERTIES

    public IHeroVisual HeroVisual { get=> heroVisual as IHeroVisual; private set => heroVisual = value as Object; }

    #endregion


}
