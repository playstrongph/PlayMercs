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
   [SerializeField] private int fightingSpirit = 0;
   
   [Header("Base Skill Stats")]
   [SerializeField] private int baseSkillCooldown;
   [SerializeField] private int baseSkillSpeed;

   [Header("Objects and Assets")]
   [SerializeField] private Sprite skillSprite = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillElementAsset))] private ScriptableObject skillElement = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTypeAsset))] private ScriptableObject skillType = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillReadinessAsset))] private ScriptableObject skillReadiness = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillEnableAsset))] private ScriptableObject skillEnableStatus = null;
   
   #endregion

   #region PROPERTIES

   public string SkillName { get => skillName; set => skillName = value; }
   public string Description { get => description; set => description = value; }
   public int SkillCooldown { get => skillCooldown; set => skillCooldown = value; }
   public int SkillSpeed { get => skillSpeed; set => skillSpeed = value; }
   
   public int FightingSpirit { get => fightingSpirit; set => fightingSpirit = value; }
   public int BaseSkillCooldown { get => baseSkillCooldown; set => baseSkillCooldown = value; }
   public int BaseSkillSpeed { get => baseSkillSpeed; set => baseSkillSpeed = value; }

   public Sprite SkillSprite { get => skillSprite; set => skillSprite = value; }
   public ISkillElementAsset SkillElement { get => skillElement as ISkillElementAsset; set=> skillElement = value as ScriptableObject;}
   public ISkillTypeAsset SkillType { get => skillType as ISkillTypeAsset; set=> skillType = value as ScriptableObject;}
   public ISkillReadinessAsset SkillReadiness { get => skillReadiness as ISkillReadinessAsset; set=> skillReadiness = value as ScriptableObject;}
   
   public ISkillEnableAsset SkillEnableStatus { get => skillEnableStatus as ISkillEnableAsset; set=> skillEnableStatus = value as ScriptableObject;}


   #endregion

   #region METHODS

   

   #endregion
}
