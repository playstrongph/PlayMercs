using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroesList))] private Object aliveHeroes;
  
        

   #endregion
        
   #region PROPERTIES

   public IHeroesList AliveHeroes { get=> aliveHeroes as IHeroesList; private set => aliveHeroes = value as Object;}

   public IBattleSceneManager BattleSceneManager { get; set; }
  

   #endregion
        
   #region METHODS

        

   #endregion
   
   
}
