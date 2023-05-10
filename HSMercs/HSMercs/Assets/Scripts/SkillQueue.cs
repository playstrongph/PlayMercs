using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using Object = UnityEngine.Object;

public class SkillQueue : MonoBehaviour, ISkillQueue
{
   #region VARIABLES
   
   [Header("For viewing purposes only")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private List<Object> skills = new List<Object>();

   #endregion

   #region PROPERTIES


   /// <summary>
   /// Returns a randomly sorted list
   /// </summary>
   public List<ISkill> Skills { get;
      private set;
   }

   #endregion

   #region METHODS

   private void Awake()
   {
      Skills = new List<ISkill>();
   }
   
   /// <summary>
   /// Add skill to Battle Manager Skill Queue
   /// </summary>
   public void AddSkillToQueue(ISkill skill)
   {
      //Debug.Log("Add to Skill Queue");

      //Add skill to the skill queue
      if (!Skills.Contains(skill))
      {
         Skills.Add(skill);
      }
      
      //Skills Queue needs to be updated everytime a skill is added
      UpdateSkillsQueue();
      
      //TODO
      //UpdateHeroDisplayedRank
   }
   
   /// <summary>
   /// Remove skill to Battle Manager Skill Queue
   /// </summary>
   public void RemoveSkillFromQueue(ISkill skill)
   {
      //Debug.Log("Remove selected skill from Skill Queue: " +skill.SkillAttributes.SkillName);
        
      //Add skill to the skill queue
      if (Skills.Contains(skill))
      {
         Skills.Remove(skill);
      }
      
      //Skills Queue needs to be updated everytime a skill is removed
      UpdateSkillsQueue();
      
      //TODO
      //UpdateHeroDisplayedRank
   }

   
   /// <summary>
   /// Sorts the Skills list in descending order according to speed
   /// also updates the "displayed" skills list in the inspector
   /// </summary>
   private void UpdateSkillsQueue()
   {
      RandomizeThenSortListInDescendingOrder(Skills);

      //Update the inspector view of the Skills Queue
      skills.Clear();
      foreach (var iSkill in Skills)
      {
         skills.Add(iSkill as Object);
      }
   }

   /// <summary>
   /// Randomizes then sorts the contents of the list according to skill speed
   /// </summary>
   /// <param name="skillsList"></param>
   /// <returns></returns>
   private void RandomizeThenSortListInDescendingOrder(List<ISkill> skillsList)
   {
      // Shuffle the list using the Fisher-Yates shuffle algorithm
      for (int i = skillsList.Count - 1; i > 0; i--)
      {
         int j = UnityEngine.Random.Range(0, i + 1);
         var temp = skillsList[i];
         skillsList[i] = skillsList[j];
         skillsList[j] = temp;
      }
      
      // Sort the list of skills by speed in descending order using bubble sort
      for (int i = 0; i < skillsList.Count - 1; i++)
      {
         for (int j = 0; j < skillsList.Count - i - 1; j++)
         {
            if (skillsList[j].SkillAttributes.SkillSpeed < skillsList[j + 1].SkillAttributes.SkillSpeed)
            {
               var temp = skillsList[j];
               skillsList[j] = skillsList[j + 1];
               skillsList[j + 1] = temp;
            }
         }
      }
   }

  


   #endregion
}
