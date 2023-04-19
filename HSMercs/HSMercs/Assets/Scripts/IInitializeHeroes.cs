using SOAssets;
using UnityEngine;

public interface IInitializeHeroes
{
    void StartAction(ITeamHeroesAsset teamHeroesAsset, GameObject heroPrefab, IHeroes heroes, IPlayer player);
}