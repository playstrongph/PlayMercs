using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class InitializeSkillsQueuePreview : MonoBehaviour, IInitializeSkillsQueuePreview
{
   #region VARIABLES

         

   #endregion
        
   #region PROPERTIES

        

   #endregion
        
   #region METHODS
   
  
   public void StartAction(GameObject skillQueuePreviewPrefab, IBattleSceneManager battleSceneManager)
   {
        //Instantiate skill queue preview object    
        var skillQueuePreviewObject = Instantiate(skillQueuePreviewPrefab, battleSceneManager.ThisGameObject.transform);
        skillQueuePreviewObject.transform.position = Vector3.zero;
        skillQueuePreviewObject.name = "SkillQueuePreview";
        
        
        
        //Set reference to the instantiated object
        var skillQueuePreview = skillQueuePreviewObject.GetComponent<ISkillQueuePreview>();
        
        //Set Battle Scene Manager reference
        battleSceneManager.SkillQueuePreview = skillQueuePreview;

   }


  


   #endregion
}
