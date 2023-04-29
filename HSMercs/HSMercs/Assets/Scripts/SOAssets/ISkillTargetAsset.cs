using System.Collections.Generic;

namespace SOAssets
{
    public interface ISkillTargetAsset
    {
        List<IHero> HeroTargets(IHero hero);
        void ShowHeroGlow(IHero hero);
        void HideHeroGlow(IHero hero);
    }
}