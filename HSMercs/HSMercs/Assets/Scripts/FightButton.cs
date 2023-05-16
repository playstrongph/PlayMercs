using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class FightButton : MonoBehaviour, IFightButton
{
   #region VARIABLES

   [SerializeField] private Image buttonImage = null;
   [SerializeField] private TextMeshProUGUI buttonText = null;
   
   [Header("Color Hex Codes")]
   [SerializeField] private string yellowColorHex = "#FFE800";
   [SerializeField] private string greenColorHex = "#77FF00";
        

   #endregion
        
   #region PROPERTIES

   public BattleSceneManager BattleSceneManager { get; set; }

   private Image ButtonImage => buttonImage;
   

   #endregion
        
   #region METHODS

   public void StartBattle()
   {
      
   }
   
   //Updates the button Text
   private void UpdateText(string newText)
   {
      buttonText.text = newText;
   }


   //Change button color to yellow
   private void ColorYellow()
   {
      //Default color in case hex code doesn't work
      var newColor = Color.yellow;

      if (ColorUtility.TryParseHtmlString(yellowColorHex, out Color parsedColor))
      {
         newColor = parsedColor;
         Debug.Log("Yellow color hex code found");
      }

      buttonImage.color = newColor;
   }
   
   //Change button color to green
   private void ColorGreen()
   {
      //Default color in case hex code doesn't work
      var newColor = Color.green;

      if (ColorUtility.TryParseHtmlString(greenColorHex, out Color parsedColor))
      {
         newColor = parsedColor;
         Debug.Log("Green color hex code found");
      }

      buttonImage.color = newColor;
   }

   #endregion
}
