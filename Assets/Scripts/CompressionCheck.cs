using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CompressionCheck : MonoBehaviour
{
   // public TextMeshPro ValueText;
    public int Compressions;


    void Start()
    {
    //    ValueText.text = Compressions.ToString();
    }
    private void OnTriggerExit()//Collider other)
    {
       // ScoreCounter.scoreValue = ScoreCounter.scoreValue + 1;
       //
       //
      // if (other.tag == "Left Hand" && other.tag == "Right Hand")

      // {
            Compressions = Compressions + 1;

            Debug.Log(Compressions);
      // }
    }
}
