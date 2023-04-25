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
   
   /// <summary>
   /// Called inside a for loop in Initialize Heroes
   /// </summary>
   /// <param name="hero"></param>
   /// <param name="player"></param>
   public void StartAction(IHero hero, IPlayer player)
   {
      //Create Hero Skills GameObject and set its correct colors
      var heroSkillsPrefab = player.BattleSceneManager.BattleSceneSettings.HeroSkillsPrefab;
      var heroSkillsGameObject = Instantiate(heroSkillsPrefab, player.BattleSceneManager.ThisGameObject.transform);
      var heroSkills = heroSkillsGameObject.GetComponent<IHeroSkills>();


      //Set Hero Reference to its skills
      hero.HeroSkills = heroSkills;
      
      //Set the correct parent game object and name for the hero skills
      heroSkillsGameObject.transform.SetParent(player.HeroSkillsTransform);
      heroSkillsGameObject.name = hero.HeroInformation.HeroName + "Skills";
      
      //Set the skill panel color based on hero class
      hero.HeroInformation.HeroClass.SetSkillPanelClassColor(hero);

      //Configuration for either 3 or 4 skills
      UpdateSkillCountConfiguration(hero);
      
      //Loads the skill information and visuals
      UpdateSkills(hero);
      
      //Hide hero skills after initialization
      heroSkills.ThisGameObject.SetActive(false);
   }


   private void UpdateSkillCountConfiguration(IHero hero)
   {
      var heroSkillsCount = hero.HeroInformation.HeroAsset.SkillAssets.Count;
      var standardSkillCount = 3;

      if (heroSkillsCount > standardSkillCount)
      {
         hero.HeroSkills.ThreeSkillPanel.ThisGameObject.SetActive(false);
         hero.HeroSkills.FourSkillPanel.ThisGameObject.SetActive(true);
      }

   }

   private void UpdateSkills(IHero hero)
   {
      var skillAssets = hero.HeroInformation.HeroAsset.SkillAssets;
      
      
         for (var index = 0; index < skillAssets.Count; index++)
         {
            var skillAsset = skillAssets[index];
            var skill = hero.HeroSkills.AllHeroSkills[index];
            var heroSkillPreview = hero.HeroVisual.HeroPreview.HeroSkillPreviews[index];
            
            //Set each skill's hero caster reference
            skill.Hero = hero;
            
            //Sets the skill and skill preview's game object tor true; specifically the 4th skill (when there are 4 skills)
            skill.ThisGameObject.SetActive(true);
            heroSkillPreview.ThisTransform.gameObject.SetActive(true);
            
            //loads the skill information
            LoadSkillAttributes(skillAsset,skill);
            
            //Load Skill Visuals
            LoadSkillVisuals(skillAsset,skill);
            
            //Load Hero Preview Skill Visuals
            LoadHeroSkillPreviewVisuals(heroSkillPreview, skill);
            
            //TODO: Apply Skill Type Visual Configuration
            LoadSkillTypeVisuals(skill);

            //TODO: Apply Skill Readiness Visual Configuration

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
      skill.SkillAttributes.SkillType = skillAsset.SkillType;
      skill.SkillAttributes.SkillReadiness = skillAsset.SkillReadiness;

   }

   private void LoadSkillVisuals(ISkillAsset skillAsset,ISkill skill)
   {
      //Skill Graphics
      skill.SkillVisual.SkillGraphics.SkillReadyGraphic.sprite = skillAsset.SkillIcon;
      skill.SkillVisual.SkillGraphics.SkillNotReadyGraphic.sprite = skillAsset.SkillIcon;
      skill.SkillVisual.SkillGraphics.PassiveSkillGraphic.sprite = skillAsset.SkillIcon;
      
      //This is the skill speed
      skill.SkillVisual.SkillGraphics.SkillReadyText.text = skill.SkillAttributes.SkillSpeed.ToString();
      
      //This is the skill cooldown
      skill.SkillVisual.SkillGraphics.SkillNotReadyText.text = skill.SkillAttributes.SkillCooldown.ToString();

      //Skill Preview
      skill.SkillVisual.SkillPreviewVisual.PreviewImage.sprite = skillAsset.SkillIcon;
      skill.SkillVisual.SkillPreviewVisual.SpeedText.text = skillAsset.SkillSpeed.ToString();
      skill.SkillVisual.SkillPreviewVisual.CooldownText.text = skillAsset.SkillCooldown.ToString();
      skill.SkillVisual.SkillPreviewVisual.SkillNameText.text = skillAsset.SkillName;
      skill.SkillVisual.SkillPreviewVisual.SkillDescriptionText.text = skillAsset.SkillDescription;
      skill.SkillVisual.SkillPreviewVisual.SkillElementText.text = skillAsset.SkillElement.ElementName;
      
      //Set Skill Preview Frame Color
      skill.Hero.HeroInformation.HeroClass.SetSkillPreviewFrameColor(skill);
   }

   private void LoadHeroSkillPreviewVisuals(IHeroSkillPreview heroSkillPreview, ISkill heroSkill)
   {
      
      
      heroSkillPreview.SkillImage.sprite = heroSkill.SkillVisual.SkillGraphics.SkillReadyGraphic.sprite;
      heroSkillPreview.HeroPreviewSkillDescription.text = heroSkill.SkillAttributes.Description;
      heroSkillPreview.HeroPreviewSkillElement.text = heroSkill.SkillAttributes.SkillElement.ElementName;
      heroSkillPreview.HeroPreviewSkillName.text = heroSkill.SkillAttributes.SkillName;
      
      heroSkill.Hero.HeroInformation.HeroClass.SetHeroSkillPreviewColors(heroSkillPreview);

   }
   
   
   private void LoadSkillTypeVisuals(ISkill skill)
   {
      //Note: 2 permission checks:  SkillType first, followed by Skill Readiness
      
      //Skill Type Visuals need to check for skill readiness status first
      skill.SkillAttributes.SkillType.LoadSkillTypeVisuals(skill);
      
   }




   #endregion
}
