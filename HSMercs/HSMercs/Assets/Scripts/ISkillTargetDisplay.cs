public interface ISkillTargetDisplay
{
    /// <summary>
    /// Hides and disables the skill targeting visuals (arrow, nodes, and cross hair)
    /// </summary>
    void HideVisuals();

    /// <summary>
    /// Enables and displays the skill target visuals (arrow, nodes, and cross hair) 
    /// </summary>
    void ShowVisuals();
    
    //Displays the Line Arrow and Cross hair
    void ShowLineArrowAndCrossHair();
}