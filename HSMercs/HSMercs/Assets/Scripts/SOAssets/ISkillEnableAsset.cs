using UnityEngine;

namespace SOAssets
{
    public interface ISkillEnableAsset
    {
        void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider);

        void SelectTarget(ISkill skill);

        void DisableTargetVisuals(ISkill skill);

        void SkillDisabledVisuals(ISkill skill);
    }
}