using UnityEngine;

namespace SOAssets
{
   
   [CreateAssetMenu(fileName = "NewSkill", menuName = "Assets/NewSkill")]
   public class SkillAsset : ScriptableObject, ISkillAsset
   {
      #region VARIABLES

      [Header("SKILL INFORMATION")] 
      [SerializeField] private string skillName = "";
      [TextArea(5, 5)] [SerializeField] private string skillDescription = "";
   
      
     
    
     
      
      [Header("Base Skill Stats")]
      [SerializeField] private int skillCooldown = 0;
      [SerializeField] private int skillSpeed = 0;
      [SerializeField] private int fightingSpirit = 0;
      
      [Header("Objects and Assets")]
      [SerializeField] private Sprite skillSprite = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillElementAsset))] private ScriptableObject skillElement = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTypeAsset))] private ScriptableObject skillType = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetAsset))] private ScriptableObject skillTarget = null;
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillReadinessAsset))] private ScriptableObject skillReadiness = null;

      #endregion

      #region PROPERTIES
   
      //Skill Information
      public string SkillName => skillName;
      public string SkillDescription => skillDescription;
      public Sprite SkillIcon => skillSprite;
      
      //Skill Stats
      public int SkillCooldown => skillCooldown;
      public int SkillSpeed => skillSpeed;
      public int FightingSpirit => fightingSpirit;
      
      public ISkillElementAsset SkillElement => skillElement as ISkillElementAsset;
      public ISkillTypeAsset SkillType => skillType as ISkillTypeAsset;
      public ISkillTargetAsset SkillTarget => skillTarget as ISkillTargetAsset;
      public ISkillReadinessAsset SkillReadiness => skillReadiness as ISkillReadinessAsset;

      #endregion

      #region METHODS



      #endregion
   }
}
