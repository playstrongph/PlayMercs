using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillQueue : MonoBehaviour
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private List<Object> skills = new List<Object>();


   #endregion

   #region PROPERTIES
   
   
   /// <summary>
   /// Returns a randomly sorted list
   /// </summary>
   public List<ISkill> Skills
   {
      get
      {
         var skillsList = new List<ISkill>();
         foreach (var skill in skills)
         { 
            skillsList.Add(skill as ISkill);
         }
         
         //TODO: randomize and sort returned skills according to skill speed
         RandomizeSortList(skillsList);
         
         return skillsList;
      }
   }


   #endregion

   #region METHODS
   
   
   private List<ISkill> RandomizeSortList(List<ISkill> skillsList)
   {
      // Shuffle the list using the Fisher-Yates shuffle algorithm
      for (int i = skillsList.Count - 1; i > 0; i--)
      {
         int j = UnityEngine.Random.Range(0, i + 1);
         var temp = skillsList[i];
         skillsList[i] = skillsList[j];
         skillsList[j] = temp;
      }
      
      // Sort the list of skills by speed in ascending order using bubble sort
      for (int i = 0; i < skillsList.Count - 1; i++)
      {
         for (int j = 0; j < skillsList.Count - i - 1; j++)
         {
            if (skillsList[j].SkillAttributes.SkillSpeed > skillsList[j + 1].SkillAttributes.SkillSpeed)
            {
               var temp = skillsList[j];
               skillsList[j] = skillsList[j + 1];
               skillsList[j + 1] = temp;
            }
         }
      }

      return skillsList;

   }


   #endregion
}
