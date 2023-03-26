using UnityEngine;

namespace SOAssets
{
   
   [CreateAssetMenu(fileName = "NewHero", menuName = "Assets/NewHero")]
   public class HeroAsset : ScriptableObject, IHeroAsset
   {
      #region VARIABLES
      
      [Header("Hero Information")]
      [SerializeField] private string heroName;
      [SerializeField] private string heroClass;
      [SerializeField] private int heroLevel;
      [SerializeField] private int heroStars;
      [SerializeField] private int heroCp;

      [SerializeField] private Sprite heroSprite;

      [Header("Hero Stats")] 
      [SerializeField] private int health;
      [SerializeField] private int attack;
      [SerializeField] private int defense;
      [SerializeField] private int speed;
      [SerializeField] private int focusPoints;
      
      
      [SerializeField] private int criticalHitChance;
      [SerializeField] private int criticalHitDamage;
      [SerializeField] private int effectiveness;
      [SerializeField] private int effectResistance;
      [SerializeField] private int dualAttackChance;
      
      //TODO - HeroSkills
      
      
      
      #endregion
        
      #region PROPERTIES

      //HERO INFORMATION
      public string HeroName { get => heroName; private set => heroName = value; }  
      public string HeroClass { get => heroClass; private set => heroClass = value; }
      public Sprite HeroSprite { get => heroSprite; private set => heroSprite = value; }
      public int HeroLevel { get => heroLevel; private set => heroLevel = value; }
      public int HeroStars { get => heroStars; private set => heroStars = value; }
      public int HeroCp { get => heroCp; private set => heroCp = value; }
      
      //HERO STATS
      public int Health { get => health; private set => health = value; }
      public int Attack { get => attack; private set => attack = value; }
      public int Defense { get => defense; private set => defense = value; }
      public int Speed { get => speed; private set => speed = value; }
      public int FocusPoints { get => focusPoints; private set => focusPoints = value; }
      
      
      public int CriticalHitChance { get => criticalHitChance; private set => criticalHitChance = value; }
      public int CriticalHitDamage { get => criticalHitDamage; private set => criticalHitDamage = value; }
      public int Effectiveness { get => effectiveness; private set => effectiveness = value; }
      public int EffectResistance { get => effectResistance; private set => effectResistance = value; }
      public int DualAttackChance { get => dualAttackChance; private set => dualAttackChance = value; }
      
      
      //TODO - HeroSkills

      #endregion
        
      #region METHODS

        

      #endregion
   }
}
