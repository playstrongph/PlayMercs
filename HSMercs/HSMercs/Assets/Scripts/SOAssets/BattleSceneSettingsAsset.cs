using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace SOAssets
{
    [CreateAssetMenu(fileName = "BattleSceneSettings", menuName = "Assets/BattleSceneGeneral/BattleSceneSettings")]
    public class BattleSceneSettingsAsset : ScriptableObject, IBattleSceneSettingsAsset
    {

    #region VARIABLES

    [SerializeField]  private GameObject heroPrefab;

    [SerializeField]  private GameObject heroSkillsPrefab;

    [SerializeField]  private GameObject playerPrefab;

    [SerializeField] private GameObject gameBoardPrefab;
    
    [SerializeField] private GameObject skillQueuePreviewPrefab;
    
   

    
    [Header("SCRIPTABLE OBJECT ASSETS")]
    [SerializeField]  [RequireInterfaceAttribute.RequireInterface(typeof(ITeamHeroesAsset))] private ScriptableObject allyTeamHeroes; 
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ITeamHeroesAsset))]private ScriptableObject enemyTeamHeroes;

    #endregion

    #region PROPERTIES

    public GameObject HeroPrefab { get=> heroPrefab; private set => heroPrefab = value;}
    //public GameObject SkillPrefab { get=> skillPrefab; private set => skillPrefab = value;}
    public GameObject HeroSkillsPrefab { get=> heroSkillsPrefab; private set => heroSkillsPrefab = value;}
    public GameObject PlayerPrefab { get=> playerPrefab; private set => playerPrefab = value;}
    public GameObject GameBoardPrefab { get=> gameBoardPrefab; private set => gameBoardPrefab = value;}
    public GameObject SkillQueuePreviewPrefab { get=> skillQueuePreviewPrefab; private set => skillQueuePreviewPrefab = value;}

    public ITeamHeroesAsset AllyTeamHeroes { get => allyTeamHeroes as ITeamHeroesAsset; private set => allyTeamHeroes = value as ScriptableObject; }
    public ITeamHeroesAsset EnemyTeamHeroes { get => enemyTeamHeroes as ITeamHeroesAsset; private set => enemyTeamHeroes = value as ScriptableObject; }


    #endregion

    #region METHODS

    private void Awake()
    {
        //throw new NotImplementedException();
    }

    #endregion


    }
}
