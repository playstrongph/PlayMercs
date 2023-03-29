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
      [SerializeField] private Sprite skillIcon = null;
      
      [Header("SKILL STATS")]
      [SerializeField] private int baseCooldownCost = 0;
      [SerializeField] private int fightingSpiritCost = 0;

      #endregion

      #region PROPERTIES
   
      //Skill Information
      public string SkillName => skillName;
      public string SkillDescription => skillDescription;
      public Sprite SkillIcon => skillIcon;
      
      //Skill Stats
      public int BaseCooldownCost => baseCooldownCost;
      public int FightingSpiritCost => fightingSpiritCost;


      #endregion

      #region METHODS



      #endregion
   }
}
