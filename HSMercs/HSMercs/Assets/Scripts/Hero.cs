using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour, IHero
{
   
    /// <summary>
    /// Reference to hero preview canvas
    /// </summary>
    [SerializeField] private Canvas previewCanvas;
    public Canvas PreviewCanvas
    {
        get => previewCanvas;
        set => previewCanvas = value;
    }
    
    
    
}
