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
      var heroSkillsGameObject = Instantiate(heroSkillsPrefab, player.BattleSceneManager.ThisGameObject.transform);
      var heroSkills = heroSkillsGameObject.GetComponent<IHeroSkills>();
      
      //Create Hero Skills GameObject
      heroSkillsGameObject.transform.SetParent(player.HeroSkillsTransform);
      heroSkillsGameObject.name = hero.HeroInformation.HeroName + "Skills";
      
      //Set Hero Reference to its skills
      hero.HeroSkills = heroSkills ;
   }

   private void LoadSkillsInformation(IHero hero, IHeroSkills heroSkills)
   {
      
      
   }


   #endregion
}
