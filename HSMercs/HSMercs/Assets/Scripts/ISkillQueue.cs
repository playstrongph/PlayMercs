using System.Collections.Generic;

public interface ISkillQueue
{
    /// <summary>
    /// Returns a randomly sorted list
    /// </summary>
    List<ISkill> Skills { get; }
    //TEST

    void AddSkillToQueue(ISkill skill);

    void RemoveSkillFromQueue(ISkill skill);
    void InitializeSkillQueuePanel(BattleSceneManager battleSceneManager);

    ISkillQueueVisual SkillQueueVisual { get; }

}