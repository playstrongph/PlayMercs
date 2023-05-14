using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class QueuePreviewHeroTargets : MonoBehaviour, IQueuePreviewHeroTargets
{
   #region VARIABLES

   //[SerializeField] private GridLayoutGroup heroesGrid = null;
   //private GridLayoutGroup HeroesGrid;

   [FormerlySerializedAs("heroTargetPreviews")] [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IQueueTargetPreview))] private List<Object> queueTargetPreviews = new List<Object>();

   [Header("SINGLE HERO TARGET")]
   //Default Values
   [SerializeField]private RectOffset singleHeroPadding = new RectOffset();
   [SerializeField] private Vector2 singleHeroCellSize = new Vector2(400,400);
   [SerializeField] private Vector2 singleHeroSpacing = new Vector2(0,0);
   [SerializeField] private GridLayoutGroup.Corner singleHeroCorner = GridLayoutGroup.Corner.UpperLeft;
   [SerializeField] private GridLayoutGroup.Axis singleHeroStartAxis = GridLayoutGroup.Axis.Vertical;
   [SerializeField] private TextAnchor singleHeroesChildAlignment = TextAnchor.MiddleCenter;
   [SerializeField] private GridLayoutGroup.Constraint singleHeroConstraint = GridLayoutGroup.Constraint.FixedRowCount;
   [SerializeField] private int singleHeroConstraintCount = 2;
   
   [Header("MULTIPLE HERO TARGETS")]
   //Default Values
   [SerializeField]private RectOffset multipleHeroPadding = new RectOffset();
   [SerializeField] private Vector2 multipleHeroCellSize = new Vector2(175,175);
   [SerializeField] private Vector2 multipleHeroSpacing = new Vector2(-80.24f,-63.4f);
   [SerializeField] private GridLayoutGroup.Corner multipleHeroCorner = GridLayoutGroup.Corner.UpperLeft;
   [SerializeField] private GridLayoutGroup.Axis multipleHeroStartAxis = GridLayoutGroup.Axis.Vertical;
   [SerializeField] private TextAnchor multipleHeroesChildAlignment = TextAnchor.MiddleLeft;
   [SerializeField] private GridLayoutGroup.Constraint multipleHeroConstraint = GridLayoutGroup.Constraint.FixedRowCount;
   [SerializeField] private int multipleHeroConstraintCount = 2;
   
   
   
   #endregion

   #region PROPERTIES

   //private GridLayoutGroup HeroesGrid => heroesGrid;
   public GridLayoutGroup HeroesGrid { get; set; }

   public Canvas Canvas { get; set; }

   public List<IHeroGraphicPreview> QueueTargetPreviews
   {
      get
      {
         var newTargetPreviews = new List<IHeroGraphicPreview>();
         foreach (var targetPreview in queueTargetPreviews)
         {
            newTargetPreviews.Add(targetPreview as IHeroGraphicPreview);
         }
         return newTargetPreviews;
      }
   }

   #endregion

   #region METHODS

   private void Awake()
   {
      HeroesGrid = GetComponent<GridLayoutGroup>();
      Canvas = GetComponent<Canvas>();
   }

   /// <summary>
   /// Changes the grid setup based on the number of heroes - 1 or many;
   /// </summary>
   /// <param name="heroTargets"></param>
   public void UpdateGridSetup(List<IHero> heroTargets)
   {
      if (heroTargets.Count > 1)
      {
         //Multi Hero Setup
         HeroesGrid.padding = multipleHeroPadding;
         HeroesGrid.cellSize = multipleHeroCellSize;
         HeroesGrid.spacing = multipleHeroSpacing;
         HeroesGrid.startCorner = multipleHeroCorner;
         HeroesGrid.startAxis = multipleHeroStartAxis;
         HeroesGrid.childAlignment = multipleHeroesChildAlignment;
         HeroesGrid.constraint = multipleHeroConstraint;
         HeroesGrid.constraintCount = multipleHeroConstraintCount;   
      }
      else
      {
         //Single Hero Setup
         HeroesGrid.padding = singleHeroPadding;
         HeroesGrid.cellSize = singleHeroCellSize;
         HeroesGrid.spacing = singleHeroSpacing;
         HeroesGrid.startCorner = singleHeroCorner;
         HeroesGrid.startAxis = singleHeroStartAxis;
         HeroesGrid.childAlignment = singleHeroesChildAlignment;
         HeroesGrid.constraint = singleHeroConstraint;
         HeroesGrid.constraintCount = singleHeroConstraintCount;   
      }
   }


   #endregion
}
