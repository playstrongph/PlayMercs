using System.Collections;
using System.Collections.Generic;
using SOAssets;
using UnityEngine;

public class BattleSceneManager : MonoBehaviour
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneSettingsAsset))] private Object battleSceneSettings;
   
   

   #endregion

   #region PROPERTIES

   public IBattleSceneSettingsAsset BattleSceneSettings { get=>battleSceneSettings as IBattleSceneSettingsAsset; private set => battleSceneSettings = value as Object;}
   public GameObject ThisGameObject => this.gameObject;

   #endregion

   #region METHODS



   #endregion
}
