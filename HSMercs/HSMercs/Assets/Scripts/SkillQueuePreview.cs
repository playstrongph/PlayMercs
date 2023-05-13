using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class SkillQueuePreview : MonoBehaviour, ISkillQueuePreview
{
   #region VARIABLES
   
   [Header("COMPONENTS")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreviewVisual))] private Object skillPreviewVisual = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroGraphicPreview))] private Object heroGraphicPreview = null;


   [Header("SKILL TARGETS")] 
   [SerializeField] private GridLayoutGroup heroGrid = null;


   #endregion

   #region PROPERTIES
   
  
   public ISkillPreviewVisual SkillPreviewVisual => skillPreviewVisual as ISkillPreviewVisual;
   
   public IHeroGraphicPreview HeroGraphicPreview => heroGraphicPreview as IHeroGraphicPreview;

   private GridLayoutGroup HeroGrid => heroGrid;
   
   

   #endregion

   #region METHODS

   private void Awake()
   {
      throw new NotImplementedException();
   }

   #endregion
}
