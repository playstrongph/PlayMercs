﻿using System.Collections.Generic;
using UnityEngine;

namespace SOAssets
{
   
   /// <summary>
   /// Fighter - Green
   /// Caster - Blue
   /// Defender - Red
   /// </summary>
   public class HeroClassAsset : ScriptableObject, IHeroClassAsset
   {
      #region VARIABLES


      #endregion
        
      #region PROPERTIES

      public virtual string ClassName { get; } = "Hero Class";


      #endregion
        
      #region METHODS

      public virtual void SetClassColor(IHeroGraphics heroGraphics)
      {
         
         heroGraphics.GreenFrame.enabled = false;
         heroGraphics.RedFrame.enabled = false;
         heroGraphics.BlueFrame.enabled = false;

         heroGraphics.GreenHeroGraphic.enabled = false;
         heroGraphics.RedHeroGraphic.enabled = false;
         heroGraphics.BlueHeroGraphic.enabled = false;
      }

      public virtual void SetSkillPanelClassColor(IHero hero)
      {
         
      }


      #endregion
   }
}
