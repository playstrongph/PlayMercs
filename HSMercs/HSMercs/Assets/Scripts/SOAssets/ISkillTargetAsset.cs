using System.Collections.Generic;

namespace SOAssets
{
    public interface ISkillTargetAsset
    {
        List<IHero> GetHeroTargets(IHero hero);
        void ResolveSpecialTargets(IHero hero);

        void ShowTargetsGlow(IHero hero);

        void HideTargetsGlow(IHero hero);
    }
}