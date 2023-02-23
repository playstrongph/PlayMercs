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

   public void StartAction(ITeamHeroesAsset teamHeroesAsset, GameObject heroPrefab, IHeroesList heroesList)
   {
      for (int i = 0; i < teamHeroesAsset.HeroCount; i++)
      {
         var herObject = Instantiate(heroPrefab, heroesList.ThisGameObject.transform);
         var hero = herObject.GetComponent<IHero>();
         
         //Add to heroes list
         heroesList.HeroesList.Add(hero);
      }
      
      //Need a coroutine here since using a method doesn't put it in its proper position
      StartCoroutine(SetHeroPreviewPosition(heroesList));
   }
   
   /// <summary>
   /// Set the hero previews into the correct world space position
   /// </summary>
   /// <param name="heroesList"></param>
   /// <returns></returns>
   private IEnumerator SetHeroPreviewPosition(IHeroesList heroesList)
   {
      yield return StartCoroutine(CenterHeroPreviewPosition(heroesList));
      
      yield return StartCoroutine(ParentBackToHero(heroesList));
      
      yield return null;
   }

   private IEnumerator CenterHeroPreviewPosition(IHeroesList heroesList)
   {
      var battleSceneManagerTransform = _player.BattleSceneManager.ThisGameObject.transform;
      
      foreach (var hero in heroesList.HeroesList)
      {
         var heroPreviewTransform = hero.HeroVisual.HeroPreview.ThisTransform;
         
         heroPreviewTransform.SetParent(battleSceneManagerTransform);
         
         heroPreviewTransform.transform.position = Vector3.zero;

      }
      
      yield return null;
   }
   
   private IEnumerator ParentBackToHero(IHeroesList heroesList)
   {
      foreach (var hero in heroesList.HeroesList)
      {
         var heroPreviewTransform = hero.HeroVisual.HeroPreview.ThisTransform;
         
         heroPreviewTransform.SetParent(hero.HeroTransform.transform);
      }
      
      yield return null;
   }


   #endregion
}
