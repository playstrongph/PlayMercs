using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillQueuePreviewVisuals : MonoBehaviour
{
  #region VARIABLES
  
  [Header("Arrow Graphics")]
  [SerializeField] private Image arrowGlow = null;
  [SerializeField] private Image skillArrow = null;
  
  [Header("Damage Graphics")]
  [SerializeField] private Image damageGraphic = null;
  [SerializeField] private Image criticalGraphic = null;
  [SerializeField] private TextMeshProUGUI damageText = null;

  #endregion

  #region PROPERTIES

  public Image ArrowGlow => arrowGlow;
  public Image SkillArrow => skillArrow;
  public Image DamageGraphic => damageGraphic;
  public Image CriticalGraphic => criticalGraphic;
  public TextMeshProUGUI DamageText => damageText;


  #endregion



}
