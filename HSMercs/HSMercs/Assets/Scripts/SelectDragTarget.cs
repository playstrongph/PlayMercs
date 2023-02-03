using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDragTarget : MonoBehaviour, ISelectDragTarget
{
    
    [SerializeField] private float distanceMultiplier = 50f;
    
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


    public void ShowLineAndTarget()
    {
        var notNormalized = transform.position - transform.parent.position;
        var direction = notNormalized.normalized;
        var distanceFromHero = (direction*distanceMultiplier).magnitude;
        
            
        //Hide Triangle and Line while target is close to HeroObject
        SkillTargetCollider.TargetArrow.SetActive(false);
        SkillTargetCollider.TargetLine.enabled = false;
            
        var difference = notNormalized.magnitude - distanceFromHero;
        var intDifference = Mathf.RoundToInt(difference);
        var index = Mathf.Clamp(intDifference, 0, 1);

        if (intDifference > 0)
        {
            DisplayLineAndTriangle(notNormalized,direction);
            
            //TEST
            SkillTargetCollider.BezierNodes.ShowArrowAndNodes();
        }

        
    }
    
    private void DisplayLineAndTriangle(Vector3 notNormalized, Vector3 direction)
    {
        //TEST - disable
        //SkillTargetCollider.TargetLine.enabled = true;
        
        SkillTargetCollider.TargetArrow.SetActive(true);
            
        SkillTargetCollider.TargetLine.SetPositions(new Vector3[]{transform.parent.position, transform.position - direction*20f});
        
        
        
        
        SkillTargetCollider.TargetArrow.transform.position = transform.position - 15f * direction;
            
        float rotZ = Mathf.Atan2(notNormalized.y, notNormalized.x) * Mathf.Rad2Deg;
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
            
        //SkillTargetCollider.CrossHair.SetActive(true);
        
        SkillTargetCollider.TargetArrow.SetActive(true);
        SkillTargetCollider.TargetLine.gameObject.SetActive(true);
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
            
        //SkillTargetCollider.CrossHair.SetActive(false);
        
        SkillTargetCollider.TargetArrow.SetActive(false);
        SkillTargetCollider.TargetLine.gameObject.SetActive(false);
        SkillTargetCollider.Draggable.DisableDraggable();
        
        //TEST
        SkillTargetCollider.BezierNodes.HideArrowAndNodes();
    }


    #region TEST
    
    

    #endregion
    


}
