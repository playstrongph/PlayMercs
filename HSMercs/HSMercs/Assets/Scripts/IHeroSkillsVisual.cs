public interface IHeroSkillsVisual
{
    /// <summary>
    /// Update the information in the hero skills display
    /// </summary>
    void UpdateSkillsDisplay();

    void HideSkillsDisplayAndScaleBackHero();
    void ShowSkillsDisplayAndScaleUpHero();

    void ShowSkillAndHeroTarget();
}