using SOAssets;
using UnityEngine;

public interface IInitializePlayerHeroes
{
    void StartAction(ITeamHeroesAsset teamHeroesAsset, GameObject heroPrefab, IHeroesList heroesList);
}