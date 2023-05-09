public interface ISkillTargeting
{
    void ShowLineAndTarget();

    void CheckEnableSkillTargetingPermissive();
    
    void EnableSkillTargeting();

    void DisableSkillTargeting();

    void ShowCrossHairAtTargetHero(IHero hero);
    void ShowArrowAtTargetHero(IHero targetHero);

}