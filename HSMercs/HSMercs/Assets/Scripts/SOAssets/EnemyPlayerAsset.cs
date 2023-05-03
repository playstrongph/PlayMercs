using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   
   [CreateAssetMenu(fileName = "EnemyPlayer", menuName = "Assets/PlayerAlliance/EnemyPlayer")]
   public class EnemyPlayerAsset : PlayerAllianceAsset
   {
     
      public override void UpdateHeroSkillsOnDisplay(IHeroSkills newHeroSkills, IPlayer player)
      {
         // 1) Disable the current hero skills on display
         player.HeroSkillsOnDisplay?.HeroSkillsVisual.HideSkillsDisplay();
      }
      
      
   }
}
