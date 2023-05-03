using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class HeroSkills : MonoBehaviour, IHeroSkills
{

    #region VARIABLES
    
    [Header("SKILL ON QUEUE")]
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private Object selectedSkill = null;
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object selectedTarget = null;
    
    [Header("COMPONENTS")]
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object threeSkillPanel;
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))] private Object fourSkillPanel;

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))]private List<Object> allHeroSkills = new List<Object>();

    [SerializeField] private Canvas skillsCanvas = null;
    
    

    #endregion

    #region PROPERTIES
    
    /// <summary>
    /// Current skill selected for execution
    /// </summary>
    public ISkill SelectedSkill { get=> selectedSkill as ISkill; set => selectedSkill = value as Object; }
    
    public IHero SelectedTarget { get=> selectedTarget as IHero; set => selectedTarget = value as Object; }

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

    public Canvas SkillsCanvas => skillsCanvas;

    public IHero CasterHero { get; set; }

    public IHeroSkillsVisual HeroSkillsVisual { get; set; }

    #endregion


    #region METHODS

    private void Awake()
    {
        RenameThisGameObjectInRunTime();
        HeroSkillsVisual = GetComponent<IHeroSkillsVisual>();
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
