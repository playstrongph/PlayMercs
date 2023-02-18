using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePrefabs : MonoBehaviour
{
   #region VARIABLES

        

   #endregion
        
   #region PROPERTIES

        

   #endregion
        
   #region METHODS

   private void OnEnable()
   {
      gameObject.SetActive(false);
   }

   private void OnApplicationQuit()
   {
      gameObject.SetActive(true);
   }

   #endregion
}
