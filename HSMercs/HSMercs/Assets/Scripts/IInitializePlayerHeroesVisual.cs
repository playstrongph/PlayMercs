using SOAssets;
using UnityEngine;

public interface IInitializePlayerHeroesVisual
{
    void StartAction(ITeamHeroesAsset teamHeroesAsset, GameObject heroPrefab, Transform heroesParent);
}