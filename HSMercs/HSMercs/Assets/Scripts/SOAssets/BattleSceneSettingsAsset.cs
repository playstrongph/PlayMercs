using UnityEngine;

namespace SOAssets
{
    [CreateAssetMenu(fileName = "BattleSceneSettings", menuName = "Assets/BattleSceneGeneral/BattleSceneSettings")]
    public class BattleSceneSettingsAsset : ScriptableObject, IBattleSceneSettingsAsset
    {

    #region VARIABLES

    /*[SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object hero;

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private Object skill;

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillsPanel))] private Object skillsPanel;

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object player;*/
    
    [SerializeField]  private GameObject heroPrefab;

    [SerializeField]  private GameObject skillPrefab;

    [SerializeField]  private GameObject skillsPanelPrefab;

    [SerializeField]  private GameObject playerPrefab;

    #endregion

    #region PROPERTIES

    public GameObject HeroPrefab { get=> heroPrefab; private set => heroPrefab = value;}
    public GameObject SkillPrefab { get=> skillPrefab; private set => skillPrefab = value;}
    public GameObject SkillsPanelPrefab { get=> skillsPanelPrefab; private set => skillsPanelPrefab = value;}
    public GameObject PlayerPrefab { get=> playerPrefab; private set => playerPrefab = value;}


    #endregion

    #region METHODS



    #endregion


    }
}
