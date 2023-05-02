using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour, IGameBoard
{
   #region VARIABLES

   [SerializeField] private string boardName = "Default Board";     

   #endregion
        
   #region PROPERTIES

   public string BoardName => boardName;

   public BoxCollider BoardCollider { get; private set; }

   public GameObject ThisGameObject { get; private set; }

   public IPlayer AllyPlayer { get; set; }
   public IPlayer EnemyPlayer { get; set; }


   #endregion
        
   #region METHODS

   private void Awake()
   {
      BoardCollider = GetComponent<BoxCollider>();
      ThisGameObject = this.gameObject;
   }

   private void OnMouseDown()
   {
      Debug.Log("Board Collider On Mouse Down");
      
      //Debug.Log("Ally Player Name: " +AllyPlayer);
      
      AllyPlayer.HeroSkillsOnDisplay?.ThisGameObject.SetActive(false);
      EnemyPlayer.HeroSkillsOnDisplay?.ThisGameObject.SetActive(false);
   }

   #endregion
}
