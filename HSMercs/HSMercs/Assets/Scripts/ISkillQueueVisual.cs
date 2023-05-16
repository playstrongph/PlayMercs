using System.Numerics;
using Vector3 = UnityEngine.Vector3;

public interface ISkillQueueVisual
{
    void UpdateSkillQueuePanel();
    Vector3 PanelPosition { get; }
}