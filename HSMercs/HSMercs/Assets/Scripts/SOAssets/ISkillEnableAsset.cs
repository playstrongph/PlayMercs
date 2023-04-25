using UnityEngine;

namespace SOAssets
{
    public interface ISkillEnableAsset
    {
        void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider);
    }
}