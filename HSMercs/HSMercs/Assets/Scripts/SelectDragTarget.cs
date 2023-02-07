using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDragTarget : MonoBehaviour, ISelectDragTarget
{
    
    [SerializeField] private float distanceMultiplier = 40;
    
    private ISkillTargetCollider SkillTargetCollider { get; set; }

    private void Awake()
    {
        SkillTargetCollider = GetComponent<ISkillTargetCollider>();
    }
    
    private void OnMouseDown()
    {
        //TEMP SCRIPT - shall be tied to skill readiness in the future
        EnableTargetVisuals();
    }
        
    private void OnMouseUp()
    {
        //TEMP SCRIPT 
        DisableTargetVisuals();
    }


    #region VISUAL METHODS


    public void ShowLineAndTarget()
    {
        var thisTransform = transform;
        var notNormalized = thisTransform.position - thisTransform.parent.position;
        var direction = notNormalized.normalized;
        var distanceFromHero = (direction*distanceMultiplier).magnitude;
        var difference = notNormalized.magnitude - distanceFromHero;
        var intDifference = Mathf.RoundToInt(difference);
        //var index = Mathf.Clamp(intDifference, 0, 1);
            
        //Hide Triangle and Line while target is close to HeroObject
        SkillTargetCollider.TargetArrow.SetActive(false);

        if (intDifference > 0)
        {
            ShowArrow(notNormalized,direction); 
            SkillTargetCollider.TargetNodes.ShowArrowNodes();
            ShowTargetCrossHair();
        }
        else 
            SkillTargetCollider.TargetNodes.HideArrowNodes();
    }
    
    private void ShowArrow(Vector3 notNormalized, Vector3 direction)
    {
        var rotZ = Mathf.Atan2(notNormalized.y, notNormalized.x) * Mathf.Rad2Deg;
        
        SkillTargetCollider.TargetArrow.SetActive(true);
        SkillTargetCollider.TargetArrow.transform.position = transform.position - 15f * direction;
        SkillTargetCollider.TargetArrow.transform.rotation = Quaternion.Euler(0f,0f,rotZ-90);
            
        //Disable Hero Preview
        //SkillTargetCollider.DisplaySkillPreview.HidePreview();  //Temp Disable
    }

    /// <summary>
    /// Enables the targeting component visuals - cross hair, triangle, and line renderer.
    /// Also enables draggable. 
    /// </summary>
    private void EnableTargetVisuals()
    {
        //Resets local position to zero
        transform.localPosition = Vector3.zero;
        SkillTargetCollider.TargetArrow.SetActive(true);
        SkillTargetCollider.Draggable.EnableDraggable();
        ShowLineAndTarget();
        
       
    }
    
    /// <summary>
    /// Disables the targeting component visuals - cross hair, triangle, and line renderer
    /// Also disables draggable.
    /// </summary>
    private void DisableTargetVisuals()
    {
        transform.localPosition = Vector3.zero;
        SkillTargetCollider.TargetArrow.SetActive(false);
        SkillTargetCollider.Draggable.DisableDraggable();
        SkillTargetCollider.TargetNodes.HideArrowNodes();
        
        HideTargetCrossHair();
    }
    
    #endregion

    #region TEST

    private void HideTargetCrossHair()
    {
        SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = false;
    }

    private void ShowTargetCrossHair()
    {
        // ReSharper disable once PossibleNullReferenceException
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Store at most 5 ray cast hits
        var mResults = new RaycastHit[5];
            
        //ray traverses all layers
        var layerMask = ~0;
            
        //Same to RayCastAll but with no additional garbage
        int hitsCount = Physics.RaycastNonAlloc(ray, mResults, Mathf.Infinity,layerMask);
            
        //Update the latest targeted hero to null
        //_validSkillTargetHero = null;
            
        //SkillTargetCollider.Skill.CasterHero.HeroLogic.LastHeroTargets.SetTargetedHero(_validSkillTargetHero);
        
        //Hide target cross hair by default
        SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = false;

        for (int i = 0; i < hitsCount; i++)
        {
            if (mResults[i].transform.GetComponent<IHeroTargetCollider>() != null)
            {
                var heroGameObject = mResults[i];
                
                //TEMP - Valid Target Checking to be introduced either here or in calling function
                
                //Display cross hair
                SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = true;
                
                //Set cross hair position to position of target hero
                SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.transform.position =
                    heroGameObject.transform.position;
            }
        }
    }


    #endregion
    


}
