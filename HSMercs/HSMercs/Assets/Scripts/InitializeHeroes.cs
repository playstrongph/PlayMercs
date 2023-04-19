using System;
using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;

public class InitializeHeroes : MonoBehaviour, IInitializeHeroes
{
   #region VARIABLES
   
  
   private IPlayer _player;

   #endregion
        
   #region PROPERTIES

   

   #endregion
        
   #region METHODS

   public void StartAction(ITeamHeroesAsset teamHeroesAsset, GameObject heroPrefab, IHeroes heroes, IPlayer player)
   {
      //Set the player
      _player = player;
      
      foreach (var heroAsset in teamHeroesAsset.HeroAssets)
      {
         var herObject = Instantiate(heroPrefab, heroes.ThisTransform);
         var hero = herObject.GetComponent<IHero>();
         
         //Add to heroes list
         heroes.HeroStatusLists.AddToAliveHeroList(hero);
         
         //Load logic stats and information
         LoadHeroStatsAndInformation(heroAsset,hero);
         
         //load hero visuals image and texts
         LoadHeroVisuals(hero);
         
         //TODO: Initialize Hero Skills
         InitializeSkills(hero);
         
      }
      
      //TO BE OBSOLETED ?
      //Need a coroutine here since using a method doesn't put it in its proper position
      StartCoroutine(SetHeroPreviewPosition(heroes));
   }

   private void LoadHeroStatsAndInformation(IHeroAsset heroAsset, IHero hero)
   {
      //Hero Information
      hero.GameObjectName.name = heroAsset.HeroName;
      hero.HeroInformation.HeroName = heroAsset.HeroName;
      hero.HeroInformation.HeroLevel = heroAsset.HeroLevel;
      hero.HeroInformation.HeroStars = heroAsset.HeroStars;
      hero.HeroInformation.HeroCp = heroAsset.HeroCp;
      hero.HeroInformation.HeroSprite = heroAsset.HeroSprite;
      
      hero.HeroInformation.HeroClass = Instantiate(heroAsset.HeroClass as ScriptableObject) as IHeroClassAsset;
      hero.HeroInformation.HeroRace = Instantiate(heroAsset.HeroRace as ScriptableObject) as IHeroRaceAsset;
      
      //Hero Stats
      hero.HeroStats.Health = heroAsset.Health;
      hero.HeroStats.Attack = heroAsset.Attack;
      hero.HeroStats.Defense = heroAsset.Defense;
      hero.HeroStats.Speed = heroAsset.Speed;
      hero.HeroStats.Armor = heroAsset.Armor;
      hero.HeroStats.FocusPoints = heroAsset.FocusPoints;
      hero.HeroStats.CriticalHitChance = heroAsset.CriticalHitChance;
      hero.HeroStats.CriticalHitDamage = heroAsset.CriticalHitDamage;
      hero.HeroStats.Effectiveness = heroAsset.Effectiveness;
      hero.HeroStats.EffectResistance = heroAsset.EffectResistance;
      hero.HeroStats.DualAttackChance = heroAsset.DualAttackChance;
      hero.HeroStats.HitChance = heroAsset.HitChance;
      
      //Base Hero Stats
      hero.BaseHeroStats.Health = heroAsset.Health;
      hero.BaseHeroStats.Attack = heroAsset.Attack;
      hero.BaseHeroStats.Defense = heroAsset.Defense;
      hero.BaseHeroStats.Speed = heroAsset.Speed;
      hero.BaseHeroStats.FocusPoints = heroAsset.FocusPoints;
      hero.BaseHeroStats.CriticalHitChance = heroAsset.CriticalHitChance;
      hero.BaseHeroStats.CriticalHitDamage = heroAsset.CriticalHitDamage;
      hero.BaseHeroStats.Effectiveness = heroAsset.Effectiveness;
      hero.BaseHeroStats.EffectResistance = heroAsset.EffectResistance;
      hero.BaseHeroStats.DualAttackChance = heroAsset.DualAttackChance;
      hero.BaseHeroStats.HitChance = heroAsset.HitChance;

   }

   private void LoadHeroVisuals(IHero hero)
   {
      var baseAttack = hero.BaseHeroStats.Attack;
      var baseHealth = hero.BaseHeroStats.Health;
      var armor = hero.HeroStats.Armor;
      
      
      //Load Hero Image
      hero.HeroVisual.HeroGraphics.SetHeroImage.SetValue();
      
      //Load Health Text
      hero.HeroVisual.HeroGraphics.SetHeroHealthText.SetValue(baseHealth);
      
      //Load Attack Text
      hero.HeroVisual.HeroGraphics.SetHeroAttackText.SetValue(baseAttack);
      
      //Load Armor Text
      hero.HeroVisual.HeroGraphics.SetHeroArmorText.SetValue(armor);
      
      //Hero Class Visuals
      hero.HeroInformation.HeroClass.SetClassColor(hero.HeroVisual.HeroGraphics);
      
      //Hero Race Visuals
      hero.HeroInformation.HeroRace.SetHeroRace(hero);
   }

   private void LoadHeroPreviewVisuals(IHero hero)
   {
      //var heroSkills = hero.
   }

   /// <summary>
   /// Set the hero previews into the correct world space position
   /// </summary>
   /// <param name="heroes"></param>
   /// <returns></returns>
   private IEnumerator SetHeroPreviewPosition(IHeroes heroes)
   {
      yield return StartCoroutine(CenterHeroPreviewPosition(heroes.HeroStatusLists));
      
      yield return StartCoroutine(SetParentToHeroPreviews(heroes.HeroStatusLists));
      
      
      
      yield return null;
   }
   
   
   /// <summary>
   /// Center the hero preview position on the board
   /// </summary>
   /// <param name="heroStatusLists"></param>  
   /// <returns></returns>
   private IEnumerator CenterHeroPreviewPosition(IHeroStatusLists heroStatusLists)
   {
      var battleSceneManagerTransform = _player.BattleSceneManager.ThisGameObject.transform;
      
      foreach (var hero in heroStatusLists.GetAliveHeroList())
      {
         var heroPreviewTransform = hero.HeroVisual.HeroPreview.ThisTransform;
         
         heroPreviewTransform.SetParent(battleSceneManagerTransform);
         
         heroPreviewTransform.transform.position = Vector3.zero;

         heroPreviewTransform.name = hero.HeroInformation.HeroName+" Preview";

      }
      
      yield return null;
   }
   
   /// <summary>
   /// Set the parent of hero previews to the parent transform
   /// </summary>
   /// <param name="heroStatusLists"></param> 
   /// <returns></returns>
   private IEnumerator SetParentToHeroPreviews(IHeroStatusLists heroStatusLists)
   {
      foreach (var hero in heroStatusLists.GetAliveHeroList())
      {
         var heroPreviewTransform = hero.HeroVisual.HeroPreview.ThisTransform;
         
         heroPreviewTransform.SetParent(_player.HeroPreviewsTransform);
      }
      
      yield return null;
   }

   private void InitializeSkills(IHero hero)
   {
      var heroSkillsPrefab = _player.BattleSceneManager.BattleSceneSettings.HeroSkillsPrefab;

      var heroSkills = Instantiate(heroSkillsPrefab, _player.BattleSceneManager.ThisGameObject.transform);
      heroSkills.transform.SetParent(_player.HeroSkillsTransform);



   }


   #endregion
}
