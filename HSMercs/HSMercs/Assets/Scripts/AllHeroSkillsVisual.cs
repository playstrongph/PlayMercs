using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AllHeroSkillsVisual : MonoBehaviour, IAllHeroSkillsVisual
{

  [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))]
  private Object threeSkillPanel;

  [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelVisual))]
  private Object fourSkillPanel;

  #region MyRegion

  public ISkillPanelVisual ThreeSkillPanel { get=> threeSkillPanel as ISkillPanelVisual; private set => threeSkillPanel = value as Object;}
  public ISkillPanelVisual FourSkillPanel { get=> fourSkillPanel as ISkillPanelVisual; private set => fourSkillPanel = value as Object;}

  #endregion

  

}
