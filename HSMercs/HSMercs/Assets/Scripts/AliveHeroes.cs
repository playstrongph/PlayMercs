using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class AliveHeroes : MonoBehaviour, IHeroesList
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object player;
   #endregion

   #region PROPERTIES

   public IPlayer Player { get=> player as IPlayer; private set => player = value as Object;}
   public List<IHero> HeroesList { get; private set; }

   public GameObject ThisGameObject => this.gameObject;


   #endregion

   #region METHODS

   private void Awake()
   {
      HeroesList = new List<IHero>();
   }

   #endregion

   #region TEST



   #endregion
}
