using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeFightButton : MonoBehaviour, IInitializeFightButton
{
   #region VARIABLES

        

   #endregion
        
   #region PROPERTIES

        

   #endregion
        
   #region METHODS

   public void StartAction(BattleSceneManager battleSceneManager)
   {
      var fightButtonPrefab = battleSceneManager.BattleSceneSettings.FightButtonPrefab;
      var fightButtonObject = Instantiate(fightButtonPrefab, battleSceneManager.ThisGameObject.transform);
      var fightButton = fightButtonObject.GetComponent<IFightButton>();
      
      //Set the parent
      fightButtonObject.transform.SetParent(battleSceneManager.ThisGameObject.transform);
      
      //Set the correct world position
      fightButtonObject.transform.position = fightButton.ButtonPosition;
      
      //Set the object name
      fightButtonObject.name = "Fight Button";
      
      //Set the fight button reference
      fightButton.BattleSceneManager = battleSceneManager;
      
      //Set the BattleSceneManager reference
      battleSceneManager.FightButton = fightButton;


   }

   #endregion
}
