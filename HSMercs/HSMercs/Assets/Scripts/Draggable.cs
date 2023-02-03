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
    
    private ISelectDragTarget SelectDragTarget { get; set; }

    private void Awake()
    {
        SkillTargetCollider = GetComponent<ISkillTargetCollider>();
        SelectDragTarget = GetComponent<ISelectDragTarget>();
        _mainCamera = Camera.main;
    }
    
    private void OnEnable()
    {
        _zDisplacement = -_mainCamera.transform.position.z + transform.position.z;
        _pointerDisplacement = -transform.position + MouseInWorldCoords();
    }
    
    private void Update()
    {
        var mousePos = MouseInWorldCoords();    
            
        transform.position = new Vector3(mousePos.x - _pointerDisplacement.x, mousePos.y - _pointerDisplacement.y, transform.position.z);
            
        SkillTargetCollider.SelectDragTarget.ShowLineAndTarget();
        
        
        
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
