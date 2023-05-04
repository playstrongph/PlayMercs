using UnityEngine;

namespace SOAssets
{
    public interface ISkillEnableAsset
    {
        void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider);

        void SetValidTargetHero(ISkill skill);

        void DisableTargetVisuals(ISkill skill);
    }
}