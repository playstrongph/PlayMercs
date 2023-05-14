using UnityEngine;

public interface ISkillQueueIcon
{
    /// <summary>
    /// Updates the skill icon graphic
    /// </summary>
    /// <param name="iconGraphic"></param>
    void UpdateSkillIconImage(Sprite iconGraphic);
    
    Transform Transform { get;}
}