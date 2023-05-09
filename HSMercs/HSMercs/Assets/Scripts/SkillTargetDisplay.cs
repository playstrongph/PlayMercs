using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkillTargetDisplay : MonoBehaviour, ISkillTargetDisplay
{
   #region VARIABLES

   private ISkillTargetCollider SkillTargetCollider { get; set; } = null;

   #endregion
        
   #region PROPERTIES

   private void Awake()
   {
      SkillTargetCollider = GetComponent<ISkillTargetCollider>();
   }


   #endregion
        
   #region METHODS
   
   /// <summary>
   /// Hides and disables the skill targeting visuals (arrow, nodes, and cross hair)
   /// </summary>
   public void HideVisuals()
   {
      var selectedSkill = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill;
      
      if(selectedSkill != null)
         selectedSkill.SkillTargetCollider.SkillTargeting.DisableSkillTargeting();
   }
   
   
   /// <summary>
   /// Enables and displays the skill target visuals (arrow, nodes, and cross hair) 
   /// </summary>
   public void ShowVisuals()
   {
      var selectedSkill = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedSkill;
      var selectedTarget = SkillTargetCollider.Skill.CasterHero.HeroSkills.SelectedTarget;
         
      if (selectedSkill != null)
      {
         
         //selectedSkill.SkillTargetCollider.SkillTargeting.ShowArrowAtTargetHero(selectedTarget);
         ShowArrowAtTargetHero(selectedTarget);
            
         //selectedSkill.SkillTargetCollider.SkillTargeting.ShowCrossHairAtTargetHero(selectedTarget);

         ShowCrossHairAtTargetHero(selectedTarget);
         
         selectedSkill.SkillTargetCollider.TargetNodes.ShowNodesAtTargetHero(selectedTarget);
         
   
         selectedSkill.SkillVisual.SkillGraphics.SkillCheckGraphic.enabled = true;
      }
   }
   
   /// <summary>
   /// Shows the cross hair at target hero
   /// </summary>
   /// <param name="hero"></param>
   private void ShowCrossHairAtTargetHero(IHero hero)
   {
      var heroTransform = hero.HeroTransform;

      SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = true;
        
      SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.transform.position =
         heroTransform.position;
   }
   
   /// <summary>
   /// Shows the Arrow at the Target Hero
   /// </summary>
   /// <param name="targetHero"></param>
   private void ShowArrowAtTargetHero(IHero targetHero)
   {
      var targetHeroTransform = targetHero.HeroTransform;
      var position = targetHeroTransform.position;
      var notNormalizedTarget = position - transform.parent.position;
        
      //var notNormalizedTarget = transform.parent.position - targetHeroTransform.position;
        
      var directionTarget = notNormalizedTarget.normalized;
        
            
      var rotZ = Mathf.Atan2(notNormalizedTarget.y, notNormalizedTarget.x) * Mathf.Rad2Deg;
        
      //SkillTargetCollider.TargetArrow.SetActive(true);

      SkillTargetCollider.TargetArrow.GetComponent<Image>().enabled = true;
        
      //SkillTargetCollider.TargetArrow.transform.position = transform.position - 15f * directionTarget;
      SkillTargetCollider.TargetArrow.transform.position = position - 15f * directionTarget;
        
      SkillTargetCollider.TargetArrow.transform.rotation = Quaternion.Euler(0f,0f,rotZ-90);
   }
        

   #endregion
}
