using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


/// <summary>
/// Component Master Reference for all components attached to 'Skill' prefab
/// </summary>
public class Skill : MonoBehaviour, ISkill
{
    #region VARIABLES
    
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual;
    
    #endregion

    #region PROPERTIES

    public ISkillVisual SkillVisual { get=> skillVisual as ISkillVisual; private set => skillVisual = value as Object; }

    public ISkillAttributes SkillAttributes { get; private set; }

    public GameObject ThisGameObject => gameObject;
    
    /// <summary>
    /// Skill's reference to its hero
    /// </summary>
    public IHero Hero { get; set; }

    #endregion

    #region METHODS

    private void Awake()
    {
        SkillAttributes = GetComponent<ISkillAttributes>();
    }

    #endregion
    
    
    
}
