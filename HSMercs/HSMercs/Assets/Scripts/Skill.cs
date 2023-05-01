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
    
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetCollider))] private Object skillTargetCollider;
    
    #endregion

    #region PROPERTIES

    public ISkillVisual SkillVisual { get=> skillVisual as ISkillVisual; private set => skillVisual = value as Object; }
    
    public ISkillTargetCollider SkillTargetCollider { get=> skillTargetCollider as ISkillTargetCollider; private set => skillTargetCollider = value as Object; }

    public ISkillAttributes SkillAttributes { get; private set; }

    public GameObject ThisGameObject => gameObject;
    
    /// <summary>
    /// Skill's reference to its hero
    /// </summary>
    public IHero CasterHero { get; set; }

    #endregion

    #region METHODS

    private void Awake()
    {
        SkillAttributes = GetComponent<ISkillAttributes>();
    }

    #endregion
    
    
    
}
