﻿using SOAssets;
using UnityEngine;

public interface IBattleSceneManager
{
    IBattleSceneSettingsAsset BattleSceneSettings { get; }
    GameObject ThisGameObject { get; }
    
     IPlayer MainPlayer { get; set; }
     IPlayer EnemyPlayer { get; set; }

     IGameBoard GameBoard { get; }

     ISkillQueue SkillQueue { get; set; }

     ISkillQueuePreview SkillQueuePreview { get; set; }
     
     IFightButton FightButton { get; set; }
     
}