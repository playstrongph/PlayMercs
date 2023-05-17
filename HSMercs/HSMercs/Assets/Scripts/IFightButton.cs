using UnityEngine;

public interface IFightButton
{
    BattleSceneManager BattleSceneManager { get; set; }
    void StartBattle();

    Vector3 ButtonPosition { get; }
}