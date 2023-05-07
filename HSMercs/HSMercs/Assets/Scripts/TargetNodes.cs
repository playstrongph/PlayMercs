using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Target Arrow Nodes
/// </summary>
public class TargetNodes : MonoBehaviour, ITargetNodes
{
    [SerializeField] private GameObject arrowNode;
    [SerializeField] private int arrowNodeNum = 10;
    [SerializeField] private float scaleFactor = 1f;
    
    private readonly List<GameObject> _arrowNodes = new List<GameObject>();
    private readonly List<Vector3> _controlPoints = new List<Vector3>();
    private GameObject ArrowNode { get => arrowNode; set => arrowNode = value; } //To avoid warning in Unity Inspector


    private void Awake()
       {
           //Creates target nodes 
           for (int i = 0; i < arrowNodeNum; i++)
           {
               var node = Instantiate(ArrowNode, transform, true);
               _arrowNodes.Add(node);
           }

           //Create Bezier Curve control points - P0,P1, and P2
           for (int i = 0; i < 3; i++)
           {
               _controlPoints.Add(Vector3.zero);
           }
           
           HideArrowNodes();

       }
        
        /// <summary>
        /// Disables the node images
        /// </summary>
        public void HideArrowNodes()
       {
           foreach (var node in _arrowNodes)
           {
               node.GetComponent<Image>().enabled = false;
           }
       }

       public void ShowArrowNodes()
       {
           //Transform where the mouse currently is
           var mouseTransform = transform;

           //Transform where the skill parent currently is
           var skillTransform = mouseTransform.parent;
           
           //P0 is where the mouse is at
           _controlPoints[0] = skillTransform.position;
           
           //P2 is where the source (skill parent) is at
           _controlPoints[2] = skillTransform.parent.position;

           //Halfway between P0 and P2, with a height of Z
           _controlPoints[1] =
              _controlPoints[0] + ((_controlPoints[2] - _controlPoints[0])/2) + new Vector3(0, 0, 100);


           for (var i = 0; i < _arrowNodes.Count; i++)
           {
               
               //Don't ask.  Haha!
               var t = (i+1.5f) / ((_arrowNodes.Count - 1) + 1f);

               //Quadratic Bezier Curve
               _arrowNodes[i].transform.position =
                   Mathf.Pow(1 - t, 2) * _controlPoints[0] +           //(1-t)^2*P0
                   2 * Mathf.Pow(1 - t, 1) * t * _controlPoints[1] +   //2*(1-t)*t*p1
                   Mathf.Pow(t, 2) * _controlPoints[2];                //t^2*P2
               
               
               //Calculates rotation for each arrow node
               if (i>0)
               {
                   var euler = new Vector3(0, 0, 
                       Vector2.SignedAngle(Vector2.up, _arrowNodes[i].transform.position - _arrowNodes[i - 1].transform.position));
                   _arrowNodes[i].transform.rotation = Quaternion.Euler(euler);
               }
   
               //calculates scales for each arrow node
               var scale = scaleFactor * (1f - 0.03f * (_arrowNodes.Count - 1 - i));
               
               _arrowNodes[i].transform.localScale = new Vector3(scale, scale, 1f);

               _arrowNodes[i].GetComponent<Image>().enabled = true;
               
           }//End of for statement
       }
       
       /// <summary>
       /// Draw nodes at selected target hero
       /// </summary>
       /// <param name="targetHero"></param>
       public void ShowNodesAtTargetHero(IHero targetHero)
       {
           //Transform where the mouse currently is

           var skillTransform = GetComponentInParent<ISkillTargetCollider>().Skill.ThisGameObject.transform;
           var targetHeroTransform = targetHero.HeroTransform;
           
           

           //P0 is where the mouse is at (the target)
           _controlPoints[0] = targetHeroTransform.position;
           
           //P2 is where the source (skill parent) is at (the source)
           _controlPoints[2] = skillTransform.position;

           //Halfway between P0 and P2, with a height of Z
           _controlPoints[1] =
              _controlPoints[0] + ((_controlPoints[2] - _controlPoints[0])/2) + new Vector3(0, 0, 100);


           for (var i = 0; i < _arrowNodes.Count; i++)
           {
               
               //Don't ask.  Haha!
               var t = (i+1.5f) / ((_arrowNodes.Count - 1) + 1f);

               //Quadratic Bezier Curve
               _arrowNodes[i].transform.position =
                   Mathf.Pow(1 - t, 2) * _controlPoints[0] +           //(1-t)^2*P0
                   2 * Mathf.Pow(1 - t, 1) * t * _controlPoints[1] +   //2*(1-t)*t*p1
                   Mathf.Pow(t, 2) * _controlPoints[2];                //t^2*P2
               
               
               //Calculates rotation for each arrow node
               if (i>0)
               {
                   var euler = new Vector3(0, 0, 
                       Vector2.SignedAngle(Vector2.up, _arrowNodes[i].transform.position - _arrowNodes[i - 1].transform.position));
                   _arrowNodes[i].transform.rotation = Quaternion.Euler(euler);
               }
   
               //calculates scales for each arrow node
               var scale = scaleFactor * (1f - 0.03f * (_arrowNodes.Count - 1 - i));
               
               _arrowNodes[i].transform.localScale = new Vector3(scale, scale, 1f);

               _arrowNodes[i].GetComponent<Image>().enabled = true;
               
           }//End of for statement
       }

       #region TEST
        
       

       #endregion

}
