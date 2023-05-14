using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class SkillQueueIcon : MonoBehaviour, ISkillQueueIcon
{
   #region VARIABLES

   [SerializeField] private Image skillIconGraphic = null;

   #endregion

   #region PROPERTIES
   private Image SkillIconGraphic => skillIconGraphic;

   public Transform Transform { get; private set; }

   #endregion

   #region METHODS

   private void Awake()
   {
      Transform = this.GetComponent<Transform>();
   }


   /// <summary>
   /// Updates the skill icon graphic
   /// </summary>
   /// <param name="iconGraphic"></param>
   public void UpdateSkillIconImage(Sprite iconGraphic)
   {
      SkillIconGraphic.sprite = iconGraphic;
   }
   
   /// <summary>
   /// TODO: Update the skill icon preview
   /// </summary>
   private void ShowSkillQueuePreview()
   {
      //Refer to SkillQueuePreview method to update the skillQueuePreview
   }
   
   private void HideSkillQueuePreview()
   {
      //Refer to SkillQueuePreview method to update the skillQueuePreview
   }
   
   
   /// <summary>
   /// Update and Show Skill Preview
   /// </summary>
   private void OnMouseEnter()
   {
      //UpdateSkillQueuePreview
   }
   
   

   #endregion
}
