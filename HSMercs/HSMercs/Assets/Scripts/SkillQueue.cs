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

   private readonly Dictionary<int, string> _speedOrderDictionary = new Dictionary<int, string>();

   public ISkillQueueVisual SkillQueueVisual { get; private set; }

   //Local Reference to the skill queue panel
   private ISkillQueueVisual _skillQueueVisual;

   /// <summary>
   /// Returns a randomly sorted list
   /// </summary>
   public List<ISkill> Skills { get; private set;
   }

   #endregion

   #region METHODS

   private void Awake()
   {
      SkillQueueVisual = GetComponent<ISkillQueueVisual>();
      Skills = new List<ISkill>();
      InitializeSpeedOrderDictionary();
   }
   
   
   /// <summary>
   /// Creates the Skill Queue Panel
   /// </summary>
   /// <param name="battleSceneManager"></param>
   public void InitializeSkillQueuePanel(BattleSceneManager battleSceneManager)
   {
      
      
      

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
      
      //Updates the Hero Speed Rank Text 
      UpdateHeroSpeedRankText();
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
      
      //Skills Queue needs to be updated everytime a skill is removed
      UpdateHeroSpeedRankText();
      
      //Set the speed rank text back to zero or "..."
      skill.CasterHero.HeroVisual.HeroGraphics.SpeedRankText.text = "...";
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
   
   
   /// <summary>
   /// Updates the displayed hero speed rank text
   /// </summary>
   private void UpdateHeroSpeedRankText()
   {
      var rank = 1;
      for (int i = 0; i < Skills.Count; i++)
      {
         //If there are 2 skills with equal speed
         if (i > 0 && Skills[i].SkillAttributes.SkillSpeed == Skills[i - 1].SkillAttributes.SkillSpeed)
         {
            
            
            //For 1st, 2nd, 3rd 
            if (rank <= 3)
            {
               var equalRank = rank - 1;
               var orderText = _speedOrderDictionary[equalRank];
            
               Skills[i].CasterHero.HeroVisual.HeroGraphics.SpeedRankText.text = orderText;
               Skills[i-1].CasterHero.HeroVisual.HeroGraphics.SpeedRankText.text = orderText;
            }
            //append "th" for 4th and above
            else
            {
               //when 2 skills are tied, the higher rank is retain - e.g. 1st/2nd/2nd, NOT 1st/3rd/3rd
               var equalRank = rank - 1;
               
               Skills[i].CasterHero.HeroVisual.HeroGraphics.SpeedRankText.text = equalRank.ToString() +"th";
               Skills[i-1].CasterHero.HeroVisual.HeroGraphics.SpeedRankText.text = equalRank.ToString() +"th";
            }

            
         }
         //If there are no equal skills
         else
         {  
            //For 1st, 2nd, 3rd 
            if (rank <= 3)
            {
               var orderText = _speedOrderDictionary[rank];
               Skills[i].CasterHero.HeroVisual.HeroGraphics.SpeedRankText.text = orderText;
            }
            //append "th" for 4th and above
            else
            {
               Skills[i].CasterHero.HeroVisual.HeroGraphics.SpeedRankText.text = rank+"th";
            }
         }
         
         rank++;
      }
   }
   
   
   /// <summary>
   /// Note: it is not foreseen to have more than 14 heroes, so the below dictionary contents shall suffice
   /// </summary>
   private void InitializeSpeedOrderDictionary()
   {
      _speedOrderDictionary.Add(1,"1st");
      _speedOrderDictionary.Add(2,"2nd");
      _speedOrderDictionary.Add(3,"3rd");
   }




   #endregion
}
