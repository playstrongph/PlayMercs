using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class Draggable : MonoBehaviour, IDraggable
{
    
    private Vector3 _pointerDisplacement;
    private float _zDisplacement;
    
    private ISkillTargetCollider SkillTargetCollider { get; set; }

    private Camera _mainCamera;
    
    private ISkillTargeting SelectDragTarget { get; set; }
    
    

    private void Awake()
    {
        SkillTargetCollider = GetComponent<ISkillTargetCollider>();
        SelectDragTarget = GetComponent<ISkillTargeting>();
        _mainCamera = Camera.main;
    }
    
    private void OnEnable()
    {
        var thisPosition = this.transform.position;
        
        _zDisplacement = -_mainCamera.transform.position.z + thisPosition.z;
        _pointerDisplacement = -thisPosition + MouseInWorldCoords();
    }
    
    private void Update()
    {
        var mousePos = MouseInWorldCoords();    
        var thisTransform = this.transform;
            
        thisTransform.position = new Vector3(mousePos.x - _pointerDisplacement.x, mousePos.y - _pointerDisplacement.y, thisTransform.position.z);
            
        SkillTargetCollider.SkillTargetDisplay.ShowLineArrowAndCrossHair();
    }
    
    private Vector3 MouseInWorldCoords()
    {
        var screenMousePos = Input.mousePosition;
        
        screenMousePos.z = _zDisplacement;
        
      
        return _mainCamera.ScreenToWorldPoint(screenMousePos);
    }
        
    /// <summary>
    /// Enables draggable script
    /// specifically, the update method
    /// </summary>
    public void EnableDraggable()
    {
        this.enabled = true;
    }
        
    /// <summary>
    /// Disables the draggable script
    /// prevents the Update method from running continuously
    /// </summary>
    public void DisableDraggable()
    {
        this.enabled = false;
    }
}
