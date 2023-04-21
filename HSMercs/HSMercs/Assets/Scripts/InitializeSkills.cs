using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;
using UnityEngine.PlayerLoop;

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
      
      UpdateSkills(hero,hero.HeroSkills);
   }

   private void UpdateSkills(IHero hero, IHeroSkills heroSkills)
   {
      var skillAssets = hero.HeroInformation.HeroAsset.SkillAssets;

      if (skillAssets.Count < 4)
      {
         //Debug.Log("AllHeroSkills: " +heroSkills.AllHeroSkills.Count);
         
         
         for (var index = 0; index < skillAssets.Count; index++)
         {
            var skillAsset = skillAssets[index];
            var skill = heroSkills.AllHeroSkills[index];
            
            Debug.Log("Skill Index: " +index);

            LoadSkillAttributes(skillAsset,skill);
            
            //TODO: Load Skill Visuals
            //LoadSkillVisuals(skillAsset,skill);
            
            //TODO: Load Hero Preview Skill Visuals
      
         }
      }
   }

   private void LoadSkillAttributes(ISkillAsset skillAsset, ISkill skill)
   {
      skill.ThisGameObject.name = skillAsset.SkillName;
      
      skill.SkillAttributes.SkillName = skillAsset.SkillName;
      skill.SkillAttributes.Description = skillAsset.SkillDescription;
      skill.SkillAttributes.SkillCooldown = skillAsset.SkillCooldown;
      skill.SkillAttributes.BaseSkillCooldown = skillAsset.SkillCooldown;
      skill.SkillAttributes.SkillSpeed = skillAsset.SkillSpeed;
      skill.SkillAttributes.BaseSkillSpeed = skillAsset.SkillSpeed;
      skill.SkillAttributes.FightingSpirit = skillAsset.FightingSpirit;
      skill.SkillAttributes.SkillSprite = skillAsset.SkillIcon;
      skill.SkillAttributes.SkillElement = skillAsset.SkillElement;
      
      //TEST
      skill.SkillVisual.SkillGraphics.SkillReadyGraphic.sprite = skillAsset.SkillIcon;
      skill.SkillVisual.SkillGraphics.SkillNotReadyGraphic.sprite = skillAsset.SkillIcon;
      skill.SkillVisual.SkillGraphics.PassiveSkillGraphic.sprite = skillAsset.SkillIcon;
      skill.SkillVisual.SkillGraphics.SkillReadyText.text = skill.SkillAttributes.SkillCooldown.ToString();
   }

   private void LoadSkillVisuals(ISkillAsset skillAsset,ISkill skill)
   {
      //Skill Graphics
      skill.SkillVisual.SkillGraphics.SkillReadyGraphic.sprite = skillAsset.SkillIcon;
      skill.SkillVisual.SkillGraphics.SkillNotReadyGraphic.sprite = skillAsset.SkillIcon;
      skill.SkillVisual.SkillGraphics.PassiveSkillGraphic.sprite = skillAsset.SkillIcon;

      skill.SkillVisual.SkillGraphics.SkillReadyText.text = skill.SkillAttributes.SkillCooldown.ToString();

      //Skill Preview







   }


   #endregion
}
