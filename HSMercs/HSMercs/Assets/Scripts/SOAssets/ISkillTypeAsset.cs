namespace SOAssets
{
    public interface ISkillTypeAsset
    {
        void LoadSkillTypeVisuals(ISkill skill);

        void SelectTarget(ISkill skill);

        void DisableTargetVisuals(ISkill skill);

        void EnableSkillTargeting(ISkill skill);
    }
}