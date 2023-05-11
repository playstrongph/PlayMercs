using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSkillsVisual : MonoBehaviour, IHeroSkillsVisual
{
   #region VARIABLES

        

   #endregion
        
   #region PROPERTIES

   private IHeroSkills HeroSkills { get; set; }

   #endregion

   #region METHODS

   private void Awake()
   {
      HeroSkills = GetComponent<IHeroSkills>();
   }
   
   /// <summary>
   /// Update all skills information and displayed visuals of the hero skills panel for ally heroes
   /// </summary>
   public void UpdateSkillsDisplay()
   {
      var player = HeroSkills.CasterHero.Player;
      var heroAlliance = HeroSkills.CasterHero.HeroInformation.PlayerAlliance;
        
      //Only display for ally heroes
      heroAlliance.UpdateHeroSkillsOnDisplay(HeroSkills,player);
   }
   
   /// <summary>
   /// Hides the current skills on display and scales back hero to normal size
   /// </summary>
   public void HideSkillsDisplayAndScaleBackHero()
   {
      //Scale back hero visuals to normal size
      HeroSkills.CasterHero.HeroTransform.localScale = Vector3.one;
      //Hide the hero skills panel
      HeroSkills.ThisGameObject.SetActive(false);

   }
   
   /// <summary>
   /// Shows current skills of and scales up the visuals of the selected hero
   /// </summary>
   public void ShowSkillsDisplayAndScaleUpHero()
   {
      //Display the hero skills panel
      HeroSkills.ThisGameObject.SetActive(true);
      
      //Scale up selected hero of "Ally" players only
      HeroSkills.CasterHero.HeroInformation.PlayerAlliance.ScaleUpSelectedHero(HeroSkills.CasterHero);
   }
   
   
   /// <summary>
   /// Display the hero skills and target visuals (arrow, nodes, cross hair) from the skill to the target hero
   /// </summary>
   public void ShowSkillAndHeroTarget()
   {
      //If there's a selected target
      if (HeroSkills.SelectedTarget != null)
      {
         //HeroSkills.SelectedSkill.SkillTargetCollider.ManualSelectTarget.ShowSelectedSkillAndTargetVisuals();
         
         //TEST
         HeroSkills.SelectedSkill.SkillTargetCollider.SkillTargetDisplay.ShowVisuals();
      }
   }
   
   #endregion

   #region TEST

  

   #endregion
}
