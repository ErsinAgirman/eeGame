using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   public static int PinCount = 0 ;
   public TextMeshProUGUI scoreText;

   void Start()
   {
    PinCount = 0;
   }

   private void Update() 
   {
     scoreText.text = PinCount.ToString(); 
   }
}
