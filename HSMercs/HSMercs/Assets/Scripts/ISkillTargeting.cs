public interface ISkillTargeting
{
    void ShowLineAndTarget();

    void EnableSkillTargeting();

    void DisableSkillTargeting();

    //TEST
    void ShowCrossHairAtTargetHero(IHero hero);
    void ShowArrowAtTargetHero(IHero targetHero);

}