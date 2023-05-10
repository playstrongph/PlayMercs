using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillQueue : MonoBehaviour, ISkillQueue
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
         
         //Randomize and sort returned skills according to skill speed
         RandomizeSortList(skillsList);
         
         return skillsList;
      }
   }
   
   /// <summary>
   /// For debugging purposes only
   /// </summary>
   public void AddToSerializedFieldSkills(ISkill skill)
   {
      var skillObject = skill as Object;
      
      if(!Skills.Contains(skill))
         skills.Add(skillObject);
   }
   
   /// <summary>
   /// For debugging purposes only
   /// </summary>
   public void RemoveFromSerializedFieldSkills(ISkill skill)
   {
      var skillObject = skill as Object;
      
      if(Skills.Contains(skill))
         skills.Remove(skillObject);
   }


   #endregion

   #region METHODS
   
   /// <summary>
   /// Randomizes then sorts the contents of the list according to skill speed
   /// </summary>
   /// <param name="skillsList"></param>
   /// <returns></returns>
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
