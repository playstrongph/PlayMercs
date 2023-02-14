using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SkillsPanelVisual : MonoBehaviour, ISkillsPanelVisual
{
  #region VARIABLES

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))]
    private Object threeSkillPanel;

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))]
    private Object fourSkillPanel;

    [SerializeField] private GameObject skillPreviewLocation;
  
  #endregion

  #region PROPERTIES

    public ISkillPanelVisual ThreeSkillPanel { get=> threeSkillPanel as ISkillPanelVisual; private set => threeSkillPanel = value as Object;}
    public ISkillPanelVisual FourSkillPanel { get=> fourSkillPanel as ISkillPanelVisual; private set => fourSkillPanel = value as Object;}

    public GameObject SkillPreviewLocation{ get => skillPreviewLocation; private set => skillPreviewLocation = value; }

  #endregion

  #region METHODS

  

  #endregion

}
