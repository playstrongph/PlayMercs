namespace SOAssets
{
    public interface IPlayerAllianceAsset
    {
        void UpdateHeroSkillsOnDisplay(IHeroSkills heroSkills, IPlayer player);

        void ScaleUpSelectedHero(IHero hero);
    }
}