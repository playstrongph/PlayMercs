using System.Collections.Generic;

public interface ISkillQueue
{
    /// <summary>
    /// Returns a randomly sorted list
    /// </summary>
    List<ISkill> Skills { get; }

    void AddToSerializedFieldSkills(ISkill skill);

    void RemoveFromSerializedFieldSkills(ISkill skill);
}