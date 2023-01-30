using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// Targetting arrow animation
/// </summary>
public class BezierArrows : MonoBehaviour
{
    [SerializeField] private GameObject arrowHead;
    [SerializeField] private GameObject arrowNode;
    [SerializeField] private int arrowNodeNum = 10;
    [SerializeField] private float scaleFactor = 1f;

    [Tooltip("P0 Control Factor")] 
    [SerializeField] private Vector2 point0ControlFactor = new Vector2(-0.3f, 0.8f);
    [Tooltip("P1 Control Factor")]
    [SerializeField] private Vector2 point1ControlFactor = new Vector2(-0.3f, 0.8f);
    
    private RectTransform _origin;
    private readonly List<RectTransform> _arrowNodes = new List<RectTransform>();
    private readonly List<Vector2> _controlPoints = new List<Vector2>();
    private readonly List<Vector2> _controPointFactors = new List<Vector2>();
           
   
       private void Awake()
       {
           //Gets position of the arrows emitter point
           _origin = GetComponent<RectTransform>();
   
           //Creates arrow nodes and arrow head
           for (int i = 0; i < arrowNodeNum; i++)
           {
              _arrowNodes.Add(Instantiate(arrowNode,transform).GetComponent<RectTransform>());
           }
           
           _controPointFactors.Add(point0ControlFactor);
           _controPointFactors.Add(point1ControlFactor);
           
           _arrowNodes.Add(Instantiate(arrowHead,transform).GetComponent<RectTransform>());
           
           
           //Hides the arrow nodes after instantiation
           foreach (var a in _arrowNodes)
           {
               a.GetComponent<RectTransform>().position = new Vector2(-1000, -1000);
           }
   
           
           //Initializes control points list
           for (int i = 0; i < 4; i++)
           {
               _controlPoints.Add(Vector2.zero);
           }
           
       }//End of Awake
   
       private void Update()
       {
           //P0 is at the arrow emitter point
           _controlPoints[0] = new Vector2(_origin.position.x, _origin.position.y);
           
           //P3 is at 
           _controlPoints[3] = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
   
           //P1 and P2 is determined by P0 and P3, and controlPointFactors
           _controlPoints[1] = _controlPoints[0] + (_controlPoints[3] - _controlPoints[0]) * this._controPointFactors[0];
           _controlPoints[2] = _controlPoints[0] + (_controlPoints[3] - _controlPoints[0]) * this._controPointFactors[1];
   
   
           for (int i = 0; i < _arrowNodes.Count; i++)
           {
               //computes 2, float value log base 2
               var t = Mathf.Log(1f*i/(_arrowNodes.Count-1)+1f,2f);
               
               //Compute Cubic Bezier Curve
               //B(t) = (1-t)^3 * P0 + 3 * (1-t)^2 * t * P1 + 3 * (1-t) * t^2 * P2 + t^3 * P3
               _arrowNodes[i].position =
                   Mathf.Pow(1 - t, 3) * _controlPoints[0] +
                   3 * Mathf.Pow(1 - t, 2) * t * _controlPoints[1] +
                   3 * (1 - t) * Mathf.Pow(t, 2) * _controlPoints[2] +
                   Mathf.Pow(t, 3) * _controlPoints[3];
               
               
               //Calculates rotation for each arrow node
               if (i>0)
               {
                   var euler = new Vector3(0, 0, 
                       Vector2.SignedAngle(Vector2.up, _arrowNodes[i].position - _arrowNodes[i - 1].position));
                   _arrowNodes[i].rotation = Quaternion.Euler(euler);
               }
   
               //calculates scales for each arrow node
               var scale = scaleFactor * (1f - 0.03f * (_arrowNodes.Count - 1 - i));
               _arrowNodes[i].localScale = new Vector3(scale, scale, 1f);
           }//End of for statement
           
           //First arrow node's rotation - this is the arrow head
           _arrowNodes[0].transform.rotation = _arrowNodes[1].transform.rotation;
   
   
       }
}
