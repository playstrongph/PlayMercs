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
    public IHeroInformation HeroInformation { get;  private set; }
    public IBaseHeroStats BaseHeroStats { get;  private set; }
    public IHeroStats HeroStats { get;  private set; }

    public GameObject GameObjectName { get => this.gameObject; private set => value = this.gameObject; }


    #endregion

    #region METHODS

    private void Awake()
    {
        HeroTransform = this.gameObject.transform;
        HeroInformation = GetComponent<IHeroInformation>();
        BaseHeroStats = GetComponent<IBaseHeroStats>();
        HeroStats = GetComponent<IHeroStats>();


    }

    #endregion


}
