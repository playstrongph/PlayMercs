using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// Targetting arrow animation
/// </summary>
public class BezierNodes : MonoBehaviour
{
    [SerializeField] private GameObject arrowNode;
    [SerializeField] private int arrowNodeNum = 10;
    [SerializeField] private float scaleFactor = 1f;

    [Tooltip("P0 Control Factor")] 
    [SerializeField] private Vector3 point0ControlFactor = new Vector3(0f, 0f,1f);
    [Tooltip("P1 Control Factor")]
    [SerializeField] private Vector3 point1ControlFactor = new Vector3(0f, 0f,1f);

    private RectTransform _origin;
    private readonly List<RectTransform> _arrowNodes = new List<RectTransform>();
    [SerializeField] private List<Vector3> _controlPoints = new List<Vector3>();
    private readonly List<Vector3> _controPointFactors = new List<Vector3>();

    private Action drawNodesAndArrow;
    
   
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
           
           HideArrowAndNodes();
           
           //Initializes control points list
           for (int i = 0; i < 4; i++)
           {
               //_controlPoints.Add(Vector2.zero);
               _controlPoints.Add(Vector3.zero);
           }

       }//End of Awake

        private void HideArrowAndNodes()
       {
           //Hides the arrow nodes after instantiation
           foreach (var node in _arrowNodes)
           {
               //why not just disable the image?
               
               node.GetComponent<RectTransform>().position = new Vector2(-1000, -1000);
           }
           
       }

       private void ShowArrowAndNodes()
       {
           //This needs to be changed by skill parent transform
           _controlPoints[0] = new Vector3(_origin.position.x, _origin.position.y,_origin.position.z);
           
           //This needs to be changed to where the mouse location is
           _controlPoints[3] = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
   
           

          _controlPoints[1] = _controlPoints[0] +Vector3.Scale((_controlPoints[3] - _controlPoints[0] + new Vector3(0,0,100)), this._controPointFactors[0]);
          _controlPoints[2] = _controlPoints[0] +Vector3.Scale((_controlPoints[3] - _controlPoints[0]+ new Vector3(0,0,0)), this._controPointFactors[1]);

          _controlPoints[1] =
              _controlPoints[0] + ((_controlPoints[3] - _controlPoints[0])/2) + new Vector3(0, 0, 100);
   
   
           for (int i = 0; i < _arrowNodes.Count; i++)
           {
               var t = (i+1) / ((_arrowNodes.Count - 1) + 1f);

               //Quadratic Bezier Curve
               _arrowNodes[i].position =
                   Mathf.Pow(1 - t, 2) * _controlPoints[0] +           //(1-t)^2*P0
                   2 * Mathf.Pow(1 - t, 1) * t * _controlPoints[1] +   //2*(1-t)*t*p1
                   Mathf.Pow(t, 2) * _controlPoints[3];                //t^2*P2
               
               
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
