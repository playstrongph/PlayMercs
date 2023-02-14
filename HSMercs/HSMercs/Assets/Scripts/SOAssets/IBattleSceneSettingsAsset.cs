namespace SOAssets
{
    public interface IBattleSceneSettingsAsset
    {
        IHero Hero { get; }
        ISkill Skill { get; }
        ISkillsPanel SkillsPanel { get; }
        IPlayer Player { get; }
    }
}