using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class HeroSkills : MonoBehaviour, IHeroSkills
{

    #region VARIABLES
    
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object skillPanelVisual;

    #endregion

    #region PROPERTIES
    
    
    public ISkillPanelVisual SkillPanelVisual { get=> skillPanelVisual as ISkillPanelVisual; private set => skillPanelVisual = value as Object;}


    #endregion


    #region METHODS

    private void Awake()
    {
        
    }

    #endregion
    
}
