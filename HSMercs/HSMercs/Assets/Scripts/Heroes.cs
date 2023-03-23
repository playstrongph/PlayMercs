using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroes : MonoBehaviour, IHeroes
{
   #region VARIABLES
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroesList))]private Object aliveHeroes;
   
   
   #endregion

   #region PROPERTIES
   
   
   public IHeroesList AliveHeroes
   {
      get => aliveHeroes as IHeroesList;
      private set => aliveHeroes = value as Object;
   }

   public Transform ThisTransform
   {
      get => transform;
      private set => value = transform;
   }

   #endregion

   #region METHODS



   #endregion
}
