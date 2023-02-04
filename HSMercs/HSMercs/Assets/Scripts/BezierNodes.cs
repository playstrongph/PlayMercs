using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Target Arrow Nodes
/// </summary>
public class BezierNodes : MonoBehaviour, IBezierNodes
{
    [SerializeField] private GameObject arrowNode;
    [SerializeField] private int arrowNodeNum = 10;
    [SerializeField] private float scaleFactor = 1f;

    //private RectTransform _origin;
    
    [SerializeField] List<GameObject> arrowNodes = new List<GameObject>();
    [SerializeField] private List<Vector3> controlPoints = new List<Vector3>();


    private GameObject ArrowNode
    {
        get => arrowNode;
        set => arrowNode = value;
    }


    private void Awake()
       {

           //Gets position of the arrows emitter point
           //_origin = GetComponent<RectTransform>();
           
           
   
           //Creates arrow nodes 
           for (int i = 0; i < arrowNodeNum; i++)
           {
               var node = Instantiate(ArrowNode, transform, true);
               arrowNodes.Add(node);
           }

           

           HideArrowAndNodes();
           
           //Quadratic Bezier control 3 control points, P0, P1, P2
           for (int i = 0; i < 3; i++)
           {
               controlPoints.Add(Vector3.zero);
           }

       }//End of Awake

        public void HideArrowAndNodes()
       {
           //Hides the arrow nodes after instantiation
           foreach (var node in arrowNodes)
           {
               //why not just disable the image?
               
               //node.GetComponent<RectTransform>().position = new Vector2(-1000, -1000);

               node.GetComponent<Image>().enabled = false;
           }
           
       }

       public void ShowArrowAndNodes()
       {
           var mouseTransform = transform;
           
           //PO is at the skill point, the arrow source (skill)
           controlPoints[0] = mouseTransform.parent.position;
           
           //P1 is the current position where the mouse is at
           controlPoints[1] = mouseTransform.position;
           
           
           
           controlPoints[1] =
              controlPoints[0] + ((controlPoints[2] - controlPoints[0])/2) + new Vector3(0, 0, 100);


           for (int i = 0; i < arrowNodes.Count; i++)
           {
               //var t = (i+1) / ((arrowNodes.Count - 1) + 1f);
               
               var t = (i+1.5f) / ((arrowNodes.Count - 1) + 1f);

               //Quadratic Bezier Curve
               arrowNodes[i].transform.position =
                   Mathf.Pow(1 - t, 2) * controlPoints[0] +           //(1-t)^2*P0
                   2 * Mathf.Pow(1 - t, 1) * t * controlPoints[1] +   //2*(1-t)*t*p1
                   Mathf.Pow(t, 2) * controlPoints[2];                //t^2*P2
               
               
               //Calculates rotation for each arrow node
               if (i>0)
               {
                   var euler = new Vector3(0, 0, 
                       Vector2.SignedAngle(Vector2.up, arrowNodes[i].transform.position - arrowNodes[i - 1].transform.position));
                   arrowNodes[i].transform.rotation = Quaternion.Euler(euler);
               }
   
               //calculates scales for each arrow node
               var scale = scaleFactor * (1f - 0.03f * (arrowNodes.Count - 1 - i));
               
               arrowNodes[i].transform.localScale = new Vector3(scale, scale, 1f);

               arrowNodes[i].GetComponent<Image>().enabled = true;
               
           }//End of for statement
           
           //First arrow node's rotation - this is the arrow head
           arrowNodes[0].transform.rotation = arrowNodes[1].transform.rotation;
       }

}
