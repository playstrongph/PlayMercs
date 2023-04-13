namespace SOAssets
{
    public interface IHeroRaceAsset
    {
        string RaceName { get; }
        void SetHeroRace(IHero hero);
    }
}