using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SkillQueueVisual : MonoBehaviour, ISkillQueueVisual
{
   #region VARIABLES

   [Header("Panel Position")]
   [SerializeField] public Vector3 panelPosition = new Vector3(-305, (float)2.6, 0);
   
   [Header("Skill Icons")]
   [SerializeField] private List<Object> skillQueueIcons = new List<Object>();

   
   

   #endregion

   #region PROPERTIES

   private ISkillQueue SkillQueue { get; set; }

   public Vector3 PanelPosition => panelPosition;
   
   private List<ISkillQueueIcon> SkillQueueIcons
   {
      get
      {
         var newSkillQueueIcons = new List<ISkillQueueIcon>();
         foreach (var skillQueueIcon in skillQueueIcons)
         {
            newSkillQueueIcons.Add(skillQueueIcon as ISkillQueueIcon);
         }
         return newSkillQueueIcons;
      }
   }

   #endregion

   #region METHODS

   private void Awake()
   {
      SkillQueue = GetComponent<ISkillQueue>();
   }

   public void UpdateSkillQueuePanel()
   {
      
   }

   #endregion
}
