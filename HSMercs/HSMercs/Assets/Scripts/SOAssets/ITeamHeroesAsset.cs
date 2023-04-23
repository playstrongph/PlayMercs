using System.Collections.Generic;

namespace SOAssets
{
    public interface ITeamHeroesAsset
    {
        IPlayerAllianceAsset PlayerAllianceAsset { get; }

        List<IHeroAsset> HeroAssets { get;}
    }
}