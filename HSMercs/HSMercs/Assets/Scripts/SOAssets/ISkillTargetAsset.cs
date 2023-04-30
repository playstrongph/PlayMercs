using System.Collections.Generic;

namespace SOAssets
{
    public interface ISkillTargetAsset
    {
        List<IHero> GetHeroTargets(IHero hero);
        void ShowHeroGlow(IHero hero);
        void HideHeroGlow(IHero hero);

        void ResolveSpecialTargets(IHero hero);
    }
}