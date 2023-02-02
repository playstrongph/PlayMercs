using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// Target Arrow Nodes
/// </summary>
public class BezierNodes : MonoBehaviour
{
    [SerializeField] private GameObject arrowNode;
    [SerializeField] private int arrowNodeNum = 10;
    [SerializeField] private float scaleFactor = 1f;

    private RectTransform _origin;
    
    private readonly List<RectTransform> _arrowNodes = new List<RectTransform>();
    [SerializeField] private List<Vector3> _controlPoints = new List<Vector3>();
    

    private void Awake()
       {

           //Gets position of the arrows emitter point
           _origin = GetComponent<RectTransform>();
   
           //Creates arrow nodes and arrow head
           for (int i = 0; i < arrowNodeNum; i++)
           {
              _arrowNodes.Add(Instantiate(arrowNode,transform).GetComponent<RectTransform>());
           }

           HideArrowAndNodes();
           
           //Quadratic Bezier control 3 control points, P0, P1, P2
           for (int i = 0; i < 3; i++)
           {
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
           _controlPoints[1] =
              _controlPoints[0] + ((_controlPoints[2] - _controlPoints[0])/2) + new Vector3(0, 0, 100);


           for (int i = 0; i < _arrowNodes.Count; i++)
           {
               var t = (i+1) / ((_arrowNodes.Count - 1) + 1f);

               //Quadratic Bezier Curve
               _arrowNodes[i].position =
                   Mathf.Pow(1 - t, 2) * _controlPoints[0] +           //(1-t)^2*P0
                   2 * Mathf.Pow(1 - t, 1) * t * _controlPoints[1] +   //2*(1-t)*t*p1
                   Mathf.Pow(t, 2) * _controlPoints[2];                //t^2*P2
               
               
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
