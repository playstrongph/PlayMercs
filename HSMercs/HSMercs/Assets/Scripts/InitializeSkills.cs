using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeSkills : MonoBehaviour, IInitializeSkills
{
   #region VARIABLES

         

   #endregion
        
   #region PROPERTIES

        

   #endregion
        
   #region METHODS

   public void StartAction(IHero hero, IPlayer player)
   {
      var heroSkillsPrefab = player.BattleSceneManager.BattleSceneSettings.HeroSkillsPrefab;

      var heroSkills = Instantiate(heroSkillsPrefab, player.BattleSceneManager.ThisGameObject.transform);
      heroSkills.transform.SetParent(player.HeroSkillsTransform);
   }     

   #endregion
}
