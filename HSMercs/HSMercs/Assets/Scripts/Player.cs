using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
   #region VARIABLES
   
   [SerializeField] private Vector3 alliesPosition = new Vector3(0, -90, 0);
   [SerializeField] private Vector3 enemiesPosition = new Vector3(0, 90, 0);
        

   #endregion
        
   #region PROPERTIES

   public IBattleSceneManager BattleSceneManager { get; set; }
   public Vector3 AlliesPosition { get => alliesPosition; private set => alliesPosition = value; }
   public Vector3 EnemiesPosition { get => enemiesPosition; private set => enemiesPosition = value; }


   #endregion
        
   #region METHODS

        

   #endregion
   
   
}
