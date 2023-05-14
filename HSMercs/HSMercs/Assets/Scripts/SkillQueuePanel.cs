using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillQueuePanel : MonoBehaviour, ISkillQueuePanel
{
   #region VARIABLES

   [SerializeField] private List<Object> skillQueueIcons = new List<Object>();

   #endregion

   #region PROPERTIES

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

   public void UpdateSkillQueuePanel()
   {
      
   }

   #endregion
}
