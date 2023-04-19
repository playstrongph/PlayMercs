using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class HeroSkills : MonoBehaviour, IHeroSkills
{

    #region VARIABLES
    
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object threeSkillPanel;
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object fourSkillPanel;

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))]private List<Object> allHeroSkills = new List<Object>();
    

    #endregion

    #region PROPERTIES

    public ISkillPanelVisual ThreeSkillPanel { get=> threeSkillPanel as ISkillPanelVisual; private set => threeSkillPanel = value as Object;}
    public ISkillPanelVisual FourSkillPanel { get=> fourSkillPanel as ISkillPanelVisual; private set => fourSkillPanel = value as Object;}
    public List<ISkill> AllHeroSkills
    {
        get
        {
            var allSkills = new List<ISkill>();
            foreach (var heroSkillObject in allHeroSkills)
            {
                var heroSkill = (ISkill) heroSkillObject;
                allSkills.Add(heroSkill);
            }
            return allSkills;
        }
    }

    public GameObject ThisGameObject => this.gameObject;

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
