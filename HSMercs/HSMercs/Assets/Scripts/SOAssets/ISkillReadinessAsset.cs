using UnityEngine;

namespace SOAssets
{
    public interface ISkillReadinessAsset
    {
        void LoadSkillReadinessVisuals(ISkill skill);

        void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider);

        void SelectTarget(ISkill skill);

        void DisableTargetVisuals(ISkill skill);
    }
}