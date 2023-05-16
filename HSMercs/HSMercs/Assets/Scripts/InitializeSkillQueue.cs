using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeSkillQueue : MonoBehaviour, IInitializeSkillQueue
{
   #region VARIABLES

        

   #endregion
        
   #region PROPERTIES

        

   #endregion
        
   #region METHODS

   public void StartAction(IBattleSceneManager battleSceneManager)
   {
      var skillQueuePanelPrefab = battleSceneManager.BattleSceneSettings.SkillQueuePanel;
      var skillQueuePanelObject = Instantiate(skillQueuePanelPrefab, battleSceneManager.ThisGameObject.transform);
      var skillQueue = skillQueuePanelObject.GetComponent<ISkillQueue>();
      
      //Set the Parent
      skillQueuePanelObject.transform.SetParent(battleSceneManager.ThisGameObject.transform);
      
      //Set the correct world position
      skillQueuePanelObject.transform.position = skillQueue.SkillQueueVisual.PanelPosition;

      //Set Reference
      battleSceneManager.SkillQueue = skillQueue;
      
      //Set the Panel Name
      skillQueuePanelObject.name = "Skill Queue Panel";
   }

   #endregion
}
