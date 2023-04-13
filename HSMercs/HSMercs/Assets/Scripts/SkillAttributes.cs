using System;
using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;
using UnityEngine.UI;

public class SkillAttributes : MonoBehaviour, ISkillAttributes
{
   #region VARIABLES
   

   [Header("Skill Information")]
   [Header("VALUES SET IN RUNTIME")]
   
   [SerializeField] private string skillName = "";
   [TextArea(5, 5)] [SerializeField] private string description = "";

   [Header("Skill Stats")] 
   [SerializeField] private int skillCooldown;
   [SerializeField] private int skillSpeed;
   
   [Header("Base Skill Stats")]
   [SerializeField] private int baseSkillCooldown;
   [SerializeField] private int baseSkillSpeed;

   [Header("Objects and Assets")]
   [SerializeField] private Sprite skillSprite = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillElementAsset))] private ScriptableObject skillElement = null;

   #endregion

   #region PROPERTIES

   public string SkillName => skillName;
   public string Description => description;
   public int SkillCooldown { get => skillCooldown; set => skillCooldown = value; }
   public int SkillSpeed { get => skillSpeed; set => skillSpeed = value; }
   public int BaseSkillCooldown { get => baseSkillCooldown; set => baseSkillCooldown = value; }
   public int BaseSkillSpeed { get => baseSkillSpeed; set => baseSkillSpeed = value; }

   public Sprite SkillSprite { get => skillSprite; set => skillSprite = value; }
   public ISkillElementAsset SkillElement { get => skillElement as ISkillElementAsset; set=> skillElement = value as ScriptableObject;}


   #endregion

   #region METHODS

   

   #endregion
}
