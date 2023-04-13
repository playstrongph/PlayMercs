namespace SOAssets
{
    public interface IHeroRaceAsset
    {
        string RaceName { get; }
        void SetPreviewRace(IHeroPreview heroPreview);
    }
}