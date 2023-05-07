public interface IManualSelectTarget
{
    void SetValidTargetHero();
    void UpdateSelectedSkillAndTarget();

    #region TEST

    void HideSelectedSkillTargetVisuals();

    void RestoreSelectedSkillTargetVisuals();

    #endregion


}