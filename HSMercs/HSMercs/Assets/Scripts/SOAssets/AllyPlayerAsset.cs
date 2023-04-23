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
         player.HeroSkillsOnDisplay?.ThisGameObject.SetActive(false);

         // 2) Replace the current hero skills on display
         player.HeroSkillsOnDisplay = newHeroSkills;
         player.OtherPlayer.HeroSkillsOnDisplay = newHeroSkills;

         // 3) Enable the current hero skills on display
         player.HeroSkillsOnDisplay.ThisGameObject.SetActive(true);
         
         // Note: Only for Ally players
      }
      
      
   }
}
