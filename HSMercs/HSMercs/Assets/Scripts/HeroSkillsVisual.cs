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
   /// Update the information in the hero skills display
   /// </summary>
   public void UpdateSkillsDisplay()
   {
      var player = HeroSkills.CasterHero.Player;
      var heroAlliance = HeroSkills.CasterHero.HeroInformation.PlayerAlliance;
        
      //only displays hero skills of ally heroes
      heroAlliance.UpdateHeroSkillsOnDisplay(HeroSkills,player);
   }
   
   /// <summary>
   /// Hides the current skills on display and scales back hero to normal size
   /// </summary>
   public void HideSkillsDisplayAndScaleBackHero()
   {
      //Scale back hero visuals to normal size
      HeroSkills.CasterHero.HeroTransform.localScale = Vector3.one;
      
      HeroSkills.ThisGameObject.SetActive(false);

   }
   
   /// <summary>
   /// Shows current skills of and scales up the visuals of the selected hero
   /// </summary>
   public void ShowSkillsDisplayAndScaleUpHero()
   {
      HeroSkills.ThisGameObject.SetActive(true);
      
      //Scale up selected hero of "Ally" players only
      HeroSkills.CasterHero.HeroInformation.PlayerAlliance.ScaleUpSelectedHero(HeroSkills.CasterHero);
   }
   
   public void ShowSkillAndHeroTarget()
   {
      if (HeroSkills.SelectedTarget != null)
      {
         HeroSkills.SelectedSkill.SkillTargetCollider.DrawTargetLineAndArrow.ShowArrowAtTargetHero(HeroSkills
            .SelectedTarget);
         
         HeroSkills.SelectedSkill.SkillTargetCollider.DrawTargetLineAndArrow.ShowCrossHairAtTargetHero(HeroSkills
            .SelectedTarget);
         
         HeroSkills.SelectedSkill.SkillTargetCollider.TargetNodes.ShowNodesAtTargetHero(HeroSkills.SelectedTarget);

         HeroSkills.SelectedSkill.SkillVisual.SkillGraphics.SkillCheckGraphic.enabled = true;
      }
   }
   
   #endregion

   #region TEST

  

   #endregion
}
