using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillVisual : MonoBehaviour, ISkillVisual
{

    #region VARIABLES
    
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillGraphics))]
    private Object skillGraphics;
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreviewVisual))]
    private Object skillPreviewVisual;

    #endregion

    #region PROPERTIES

    public ISkillGraphics SkillGraphics { get=> skillGraphics as ISkillGraphics; private set => skillGraphics = value as Object; }
    public ISkillPreviewVisual SkillPreviewVisual { get=> skillPreviewVisual as ISkillPreviewVisual; private set => skillPreviewVisual = value as Object; }
    
    #endregion
    
}
