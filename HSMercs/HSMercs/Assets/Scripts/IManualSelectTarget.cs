public interface IManualSelectTarget
{
    IHero LocalSkillSelectedTarget { get; set; }
    
    void SelectTarget();

    void CheckSelectTargetPermissive();



    #region TEST




    #endregion


}