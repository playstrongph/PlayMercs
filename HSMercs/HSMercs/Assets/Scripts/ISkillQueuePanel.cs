using System.Numerics;
using Vector3 = UnityEngine.Vector3;

public interface ISkillQueuePanel
{
    void UpdateSkillQueuePanel();
    Vector3 PanelPosition { get; }
}