using System.Collections.Generic;

namespace SOAssets
{
    public interface ITeamHeroesAsset
    {
        int HeroCount { get; }

        List<IHeroAsset> HeroAssets { get;}
    }
}