using System.Collections.Generic;
using UnityEngine;


public class AliveHeroes : MonoBehaviour, IHeroesList
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object player;
   
   [Header("SET IN RUNTIME")] 
   [SerializeField] private List<GameObject> heroesList = new List<GameObject>();


   #endregion

   #region PROPERTIES

   public IPlayer Player { get=> player as IPlayer; private set => player = value as Object; }
   public List<GameObject> HeroesListGameObjects => heroesList;
   public List<IHero> HeroesList
   {
      get
      {
         var newHeroes = new List<IHero>();
         foreach (var heroObject in heroesList)
         {
            var hero = heroObject.GetComponent<IHero>();
            newHeroes.Add(hero);
         }
         return newHeroes;
      }
   }

   public GameObject ThisGameObject => this.gameObject;


   #endregion

   #region METHODS



   #endregion

   #region TEST



   #endregion
}
