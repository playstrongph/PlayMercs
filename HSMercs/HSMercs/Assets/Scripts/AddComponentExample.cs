using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddComponentExample : MonoBehaviour
{
   #region VARIABLES

        

   #endregion
        
   #region PROPERTIES

        

   #endregion
        
   #region METHODS

        

   #endregion

   #region TEST

   //Just an example
   private IPlayer _player;

   private void Awake()
   {
      _player = GetComponentInParent<IPlayer>();
   }

   private void Start()
   {
      AddComponentNew(_player.GetType());
   }
   
   private void AddComponentNew(Type aType)
   {
      var inst = gameObject.AddComponent(aType);
   }

   #endregion
}
