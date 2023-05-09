using System.Collections;
using System.Collections.Generic;
using UnityEngine;



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
         selectedSkill.SkillTargetCollider.SkillTargeting.ShowArrowAtTargetHero(selectedTarget);
            
         selectedSkill.SkillTargetCollider.SkillTargeting.ShowCrossHairAtTargetHero(selectedTarget);
            
         selectedSkill.SkillTargetCollider.TargetNodes.ShowNodesAtTargetHero(selectedTarget);
   
         selectedSkill.SkillVisual.SkillGraphics.SkillCheckGraphic.enabled = true;
      }
   }
        

   #endregion
}
