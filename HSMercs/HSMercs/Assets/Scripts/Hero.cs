using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Hero : MonoBehaviour, IHero
{
    #region VARIABLES

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))]
    private Object heroVisual;

    #endregion


    #region PROPERTIES

    public IHeroVisual HeroVisual { get=> heroVisual as IHeroVisual; private set => heroVisual = value as Object; }
    public Transform HeroTransform { get; private set; }

    #endregion

    #region METHODS

    private void Awake()
    {
        HeroTransform = this.gameObject.transform;
    }

    #endregion


}
