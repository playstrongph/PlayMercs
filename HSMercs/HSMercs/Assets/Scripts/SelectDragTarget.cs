using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDragTarget : MonoBehaviour, ISelectDragTarget
{

    private ISkillTargetCollider SkillTargetCollider { get; set; }

    private void Awake()
    {
        SkillTargetCollider = GetComponent<ISkillTargetCollider>();
    }


    public void ShowLineAndTarget()
    {
        var notNormalized = transform.position - transform.parent.position;
        var direction = notNormalized.normalized;
        var distanceFromHero = (direction*50f).magnitude;
        
            
        //Hide Triangle and Line while target is close to HeroObject
        SkillTargetCollider.TargetArrow.SetActive(false);
        SkillTargetCollider.TargetLine.enabled = false;
            
        var difference = notNormalized.magnitude - distanceFromHero;
        var intDifference = Mathf.RoundToInt(difference);
        var index = Mathf.Clamp(intDifference, 0, 1);

        if (intDifference > 0)
            DisplayLineAndTriangle(notNormalized,direction);
    }
    
    private void DisplayLineAndTriangle(Vector3 notNormalized, Vector3 direction)
    {
        SkillTargetCollider.TargetLine.enabled = true;
        SkillTargetCollider.TargetArrow.SetActive(true);
            
        SkillTargetCollider.TargetLine.SetPositions(new Vector3[]{transform.parent.position, transform.position - direction*20f});
        SkillTargetCollider.TargetArrow.transform.position = transform.position - 15f * direction;
            
        float rotZ = Mathf.Atan2(notNormalized.y, notNormalized.x) * Mathf.Rad2Deg;
        SkillTargetCollider.TargetArrow.transform.rotation = Quaternion.Euler(0f,0f,rotZ-90);
            
        //Disable Hero Preview
        //SkillTargetCollider.DisplaySkillPreview.HidePreview();  //Temp Disable

    }
    
    
    
}
