using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayersVisual : MonoBehaviour
{
   //********************************//
   #region VARIABLES

   private IBattleSceneManager _battleSceneManager;

   #endregion
   //********************************//
   
   
   //********************************//
   #region PROPERTIES



   #endregion
   //********************************//
   
   //********************************//
   #region METHODS

   private void Awake()
   {
      _battleSceneManager = GetComponent<IBattleSceneManager>();
   }

   #endregion
   //********************************//
}
