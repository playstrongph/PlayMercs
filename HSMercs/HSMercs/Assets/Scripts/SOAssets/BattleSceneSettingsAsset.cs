using UnityEngine;

namespace SOAssets
{
    [CreateAssetMenu(fileName = "BattleSceneSettings", menuName = "Assets/BattleSceneGeneral/BattleSceneSettings")]
    public class BattleSceneSettingsAsset : ScriptableObject, IBattleSceneSettingsAsset
    {

    #region VARIABLES

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object hero;

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private Object skill;

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillsPanel))] private Object skillsPanel;

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object player;

    #endregion

    #region PROPERTIES

    public IHero Hero { get=> hero as IHero; private set => hero = value as Object;}
    
    public ISkill Skill { get=> skill as ISkill; private set => skill = value as Object;}

    public ISkillsPanel SkillsPanel { get=> skillsPanel as ISkillsPanel; private set => skillsPanel = value as Object;}

    public IPlayer Player { get=> player as IPlayer; private set => player = value as Object;}


    #endregion

    #region METHODS



    #endregion


    }
}
