using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualSelectTarget : MonoBehaviour
{
   #region VARIABLES

   /// <summary>
   /// List of valid hero targets taken during
   /// on mouse down event
   /// </summary>
   private List<IHero> _validTargets = new List<IHero>();
        
   /// <summary>
   /// The intended target hero for the skill being used
   /// reset to null when target selected is not valid
   /// </summary>
   //private IHero _validSkillTargetHero = null;

   [SerializeField] private Object validTarget = null;

   #endregion
        
   #region PROPERTIES
   
   

   private IHero ValidTarget
   {
      get => validTarget as IHero;
      set => validTarget = value as Object;
   }


   #endregion
        
   #region METHODS

   private void SetValidTargetHero()
   {
      // ReSharper disable once PossibleNullReferenceException
      var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

      //Store at most 5 ray cast hits
      var mResults = new RaycastHit[5];
            
      //ray traverses all layers
      var layerMask = ~0;
      
      //TODO:
      
            
      //Same to RayCastAll but with no additional garbage
      int hitsCount = Physics.RaycastNonAlloc(ray, mResults, Mathf.Infinity,layerMask);
            
      //Update the latest targeted hero to null
      ValidTarget = null;

      for (int i = 0; i < hitsCount; i++)
      {
         if (mResults[i].transform.GetComponent<IHeroTargetCollider>() != null)
         {
            var targetHeroCollider = mResults[i].transform.GetComponent<IHeroTargetCollider>();
            
            
            //TODO: _validTargets should be a method call of GetValidTargets

            //check if hero is included in the valid targets.  Set hero to targetHero or Null;
            ValidTarget = _validTargets.Contains(targetHeroCollider.Hero) ? targetHeroCollider.Hero : null;
         }

      }
   }     

   #endregion
}
