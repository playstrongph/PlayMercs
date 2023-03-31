using System;
using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;

public class InitializePlayerHeroes : MonoBehaviour, IInitializePlayerHeroes
{
   #region VARIABLES
   
  
   private IPlayer _player;

   #endregion
        
   #region PROPERTIES

   

   #endregion
        
   #region METHODS

   private void Awake()
   {
      _player = GetComponent<IPlayer>();
   }

   public void StartAction(ITeamHeroesAsset teamHeroesAsset, GameObject heroPrefab, IHeroes heroes)
   {
      for (int i = 0; i < teamHeroesAsset.HeroCount; i++)
      {
         var herObject = Instantiate(heroPrefab, heroes.ThisTransform);
         var hero = herObject.GetComponent<IHero>();
         
         //Add to heroes list
         heroes.HeroStatusLists.AddToAliveHeroList(hero);

         //Load Hero Stats and Attributes
         
         
         //Load Hero and Skill previews
      }
      
      //TO BE OBSOLETED ?
      //Need a coroutine here since using a method doesn't put it in its proper position
      StartCoroutine(SetHeroPreviewPosition(heroes));
   }

   private void LoadHeroStatsAndInformation()
   {
      
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


   #endregion
}
