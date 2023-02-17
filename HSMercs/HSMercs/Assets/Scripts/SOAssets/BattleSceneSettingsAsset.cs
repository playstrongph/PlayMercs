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
    
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object heroPrefab;

    [SerializeField]  [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))]private Object skillPrefab;

    [SerializeField]  [RequireInterfaceAttribute.RequireInterface(typeof(ISkillsPanel))] private Object skillsPanelPrefab;

    [SerializeField]  [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))]private Object playerPrefab;

    #endregion

    #region PROPERTIES

    public GameObject HeroPrefab { get=> heroPrefab as GameObject; private set => heroPrefab = value as Object;}
    public GameObject SkillPrefab { get=> skillPrefab as GameObject; private set => skillPrefab = value as Object;}
    public GameObject SkillsPanelPrefab { get=> skillsPanelPrefab as GameObject; private set => skillsPanelPrefab = value as Object;}
    public GameObject PlayerPrefab { get=> playerPrefab as GameObject; private set => playerPrefab = value as Object;}


    #endregion

    #region METHODS



    #endregion


    }
}
