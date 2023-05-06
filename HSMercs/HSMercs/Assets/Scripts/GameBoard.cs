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
   
   /// <summary>
   /// This utilizes the box collider
   /// </summary>
   private void OnMouseDown()
   {
      AllyPlayer.HeroSkillsOnDisplay?.HeroSkillsVisual.HideSkillsDisplayAndScaleBackHero();
      EnemyPlayer.HeroSkillsOnDisplay?.HeroSkillsVisual.HideSkillsDisplayAndScaleBackHero();
   }

   #endregion
}
