using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class HeroSkills : MonoBehaviour, IHeroSkills
{

    #region VARIABLES
    
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object threeSkillPanelVisual;
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object fourSkillPanelVisual;

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))]private List<Object> allHeroSkills = new List<Object>();
    

    #endregion

    #region PROPERTIES

    public ISkillPanelVisual ThreeSkillPanelVisual { get=> threeSkillPanelVisual as ISkillPanelVisual; private set => threeSkillPanelVisual = value as Object;}
    
    public ISkillPanelVisual FourSkillPanelVisual { get=> fourSkillPanelVisual as ISkillPanelVisual; private set => fourSkillPanelVisual = value as Object;}
    public List<ISkill> AllHeroSkills
    {
        get
        {
            var allSkills = new List<ISkill>();
            foreach (var heroSkillObject in allSkills)
            {
                var heroSkill = (ISkill) heroSkillObject;
                allSkills.Add(heroSkill);
            }
            return allSkills;
        }
    }

    #endregion


    #region METHODS

    private void Awake()
    {
        RenameThisGameObjectInRunTime();
    }
    
    
    /// <summary>
    /// Changes the game object name to 'HeroSkills' in RunTime
    /// </summary>
    private void RenameThisGameObjectInRunTime()
    {
        this.gameObject.name = this.GetType().Name;
    }

    #endregion
    
}
