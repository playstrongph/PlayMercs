using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHeroPreview : MonoBehaviour, IDisplayHeroPreview
{
    

    /*[SerializeField] private float displayDelay = 0.5f;
    [SerializeField] private bool enablePreview = false;*/
    
    private IHeroTargetCollider _heroTargetCollider;


    private void Awake()
    {
        _heroTargetCollider = GetComponent<IHeroTargetCollider>();
    }
    
    
    
    
}
