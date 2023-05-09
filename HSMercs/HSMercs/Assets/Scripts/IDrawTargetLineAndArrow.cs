public interface IDrawTargetLineAndArrow
{
    void ShowLineAndTarget();

    void EnableSkillTargeting();

    void DisableSkillTargeting();

    //TEST
    void ShowCrossHairAtTargetHero(IHero hero);
    void ShowArrowAtTargetHero(IHero targetHero);

}