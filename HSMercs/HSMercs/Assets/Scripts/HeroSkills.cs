using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSkills : MonoBehaviour, IHeroSkills
{

    #region VARIABLES

    

    #endregion

    #region PROPERTIES

    public IHeroSkillsVisual HeroSkillsVisual { get; private set; }


    #endregion


    #region METHODS

    private void Awake()
    {
        HeroSkillsVisual = GetComponent<IHeroSkillsVisual>();
    }

    #endregion
    
}
