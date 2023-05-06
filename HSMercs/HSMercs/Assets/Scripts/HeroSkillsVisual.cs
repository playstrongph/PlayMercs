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

   public void HideSkillsDisplay()
   {
      //TEST
      var lastSelectedHero = HeroSkills.CasterHero;

      if (lastSelectedHero != null)
         lastSelectedHero.HeroTransform.localScale = Vector3.one;
      
      HeroSkills.ThisGameObject.SetActive(false);

   }

   public void ShowSkillsDisplay()
   {
      HeroSkills.ThisGameObject.SetActive(true);
   }
   #endregion

   #region TEST

   public void ShowSkillAndHeroTarget()
   {
      if (HeroSkills.SelectedTarget != null)
      {
         HeroSkills.SelectedSkill.SkillTargetCollider.DrawTargetLineAndArrow.ShowArrowAtTargetHero(HeroSkills
            .SelectedTarget);
         
         HeroSkills.SelectedSkill.SkillTargetCollider.DrawTargetLineAndArrow.ShowCrossHairAtTargetHero(HeroSkills
            .SelectedTarget);
         
         HeroSkills.SelectedSkill.SkillTargetCollider.TargetNodes.ShowNodesAtTargetHero(HeroSkills.SelectedTarget);
      }
   }

   #endregion
}
