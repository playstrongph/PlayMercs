using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   
   [CreateAssetMenu(fileName = "AllyPlayer", menuName = "Assets/PlayerAlliance/AllyPlayer")]
   public class AllyPlayerAsset : PlayerAllianceAsset
   {
     
      /// <summary>
      /// Updates the hero skills on display after hero is selected
      /// </summary>
      /// <param name="newHeroSkills"></param>
      /// <param name="player"></param>
      public override void UpdateHeroSkillsOnDisplay(IHeroSkills newHeroSkills, IPlayer player)
      {
         // 1) Disable the current hero skills on display
         player.HeroSkillsOnDisplay?.HeroSkillsVisual.HideSkillsDisplayAndScaleBackHero();
        

         // 2) Replace the current hero skills on display
         player.HeroSkillsOnDisplay = newHeroSkills;
         player.OtherPlayer.HeroSkillsOnDisplay = newHeroSkills;

         // 3) Enable the current hero skills on display
         player.HeroSkillsOnDisplay?.HeroSkillsVisual.ShowSkillsDisplayAndScaleUpHero();
         
         // Note: Only for Ally players
      }
      
      public override void ScaleUpSelectedHero(IHero hero)
      {
         //Values tested in inspector
         var newScale = new Vector3(1.5f, 1.5f, 1f);

         hero.HeroTransform.localScale = newScale;
      }
      
   }
}
