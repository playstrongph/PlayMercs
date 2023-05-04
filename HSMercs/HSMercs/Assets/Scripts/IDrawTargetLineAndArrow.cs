public interface IDrawTargetLineAndArrow
{
    void ShowLineAndTarget();

    void EnableTargetVisuals();

    void DisableTargetVisuals();

    //TEST
    void ShowCrossHairAtTargetHero(IHero hero);
    void ShowArrowAtTargetHero(IHero targetHero);

}