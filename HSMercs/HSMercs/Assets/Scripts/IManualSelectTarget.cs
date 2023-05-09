public interface IManualSelectTarget
{
    void SelectTarget();

    void HideSelectedSkillTargetVisuals();

    void ShowSkillAndHeroTarget();
    
    IHero LocalSkillSelectedTarget { get; set; }

    #region TEST




    #endregion


}