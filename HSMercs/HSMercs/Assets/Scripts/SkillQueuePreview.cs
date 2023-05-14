using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class SkillQueuePreview : MonoBehaviour, ISkillQueuePreview
{
   #region VARIABLES
   
   [FormerlySerializedAs("skillPreviewVisual")]
   [Header("COMPONENTS")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IQueueSkillPreviewVisual))] private Object queuesSkillPreviewVisual = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IQueueHeroPreviewVisual))] private Object queueHeroPreviewVisual = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IQueuePreviewHeroTargets))] private Object skillPreviewTargets = null;
   
   


   


   #endregion

   #region PROPERTIES
   
  
   public IQueueSkillPreviewVisual QueuesSkillPreviewVisual => queuesSkillPreviewVisual as IQueueSkillPreviewVisual;
   
   public IQueueHeroPreviewVisual QueueHeroPreviewVisual => queueHeroPreviewVisual as IQueueHeroPreviewVisual;
   
   public IQueuePreviewHeroTargets QueuePreviewHeroTargets => skillPreviewTargets as IQueuePreviewHeroTargets;

   public Canvas Canvas { get; private set; }






   #endregion

   #region METHODS

   private void Awake()
   {
      Canvas = GetComponent<Canvas>();
   }

   #endregion
}
