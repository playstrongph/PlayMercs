using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    #endregion
    
    
    
}
