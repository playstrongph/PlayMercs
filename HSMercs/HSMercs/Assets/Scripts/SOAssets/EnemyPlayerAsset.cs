using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   
   [CreateAssetMenu(fileName = "EnemyPlayer", menuName = "Assets/PlayerAlliance/EnemyPlayer")]
   public class EnemyPlayerAsset : PlayerAllianceAsset
   {
     
      public override void UpdateHeroSkillsOnDisplay(IHeroSkills newHeroSkills, IPlayer player)
      {
         //Disable the current hero skills on display
         player.HeroSkillsOnDisplay?.HeroSkillsVisual.HideSkillsDisplay();

         //Set the HeroSkills on display to null
         player.HeroSkillsOnDisplay = null;
         player.OtherPlayer.HeroSkillsOnDisplay = null;
      }
      
      
   }
}
