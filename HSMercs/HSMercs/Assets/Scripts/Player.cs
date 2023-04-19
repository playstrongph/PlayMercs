using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Object = UnityEngine.Object;

public class Player : MonoBehaviour, IPlayer
{
   #region VARIABLES

   //[SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroesList))] private Object aliveHeroes;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroes))] private Object heroes;
   
   [SerializeField] private Transform heroPreviewsTransform;
   
   [SerializeField] private Transform heroSkillsTransform;
        

   #endregion
        
   #region PROPERTIES

   //public IHeroesList AliveHeroes { get=> aliveHeroes as IHeroesList; private set => aliveHeroes = value as Object;}

   public IBattleSceneManager BattleSceneManager { get; set; }

   public IHeroes Heroes { get => heroes as IHeroes; private set => heroes = value as Object; }
   public Transform HeroPreviewsTransform { get => heroPreviewsTransform; private set => heroPreviewsTransform = value; }
   
   public Transform HeroSkillsTransform { get => heroSkillsTransform; private set => heroSkillsTransform = value; }


   #endregion
        
   #region METHODS

   

   #endregion
   
   
}
