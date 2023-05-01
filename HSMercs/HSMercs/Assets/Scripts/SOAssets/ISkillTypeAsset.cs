namespace SOAssets
{
    public interface ISkillTypeAsset
    {
        void LoadSkillTypeVisuals(ISkill skill);

        void SetValidTargetHero(ISkill skill);
    }
}