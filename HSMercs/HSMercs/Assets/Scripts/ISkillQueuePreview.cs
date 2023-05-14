using UnityEngine;

public interface ISkillQueuePreview
{
    IQueueSkillPreviewVisual QueuesSkillPreviewVisual { get; }
    IQueueHeroPreviewVisual QueueHeroPreviewVisual { get; }
    IQueuePreviewHeroTargets QueuePreviewHeroTargets { get; }

    Canvas Canvas { get; }
}