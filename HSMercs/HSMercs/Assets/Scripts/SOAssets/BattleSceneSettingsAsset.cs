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

    [SerializeField]  private GameObject heroPrefab=null;

    [SerializeField]  private GameObject heroSkillsPrefab=null;

    [SerializeField]  private GameObject playerPrefab= null;

    [SerializeField] private GameObject gameBoardPrefab = null;
    
    [SerializeField] private GameObject skillQueuePanel =null;
    
    [SerializeField] private GameObject skillQueuePreviewPrefab = null;
    
    [SerializeField] private GameObject fightButtonPrefab = null;
   

    
    [Header("SCRIPTABLE OBJECT ASSETS")]
    [SerializeField]  [RequireInterfaceAttribute.RequireInterface(typeof(ITeamHeroesAsset))] private ScriptableObject allyTeamHeroes; 
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ITeamHeroesAsset))]private ScriptableObject enemyTeamHeroes;

    #endregion

    #region PROPERTIES

    public GameObject HeroPrefab => heroPrefab;
    public GameObject HeroSkillsPrefab => heroSkillsPrefab;
    public GameObject PlayerPrefab => playerPrefab;
    public GameObject GameBoardPrefab => gameBoardPrefab;
    public GameObject SkillQueuePanel => skillQueuePanel;
    public GameObject SkillQueuePreviewPrefab => skillQueuePreviewPrefab; 
    
    public GameObject FightButtonPrefab => fightButtonPrefab;

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
