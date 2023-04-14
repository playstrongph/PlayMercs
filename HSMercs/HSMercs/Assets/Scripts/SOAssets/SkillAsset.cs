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

      #endregion

      #region METHODS



      #endregion
   }
}
