using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.TerrainTools;

public class CompressionCheck : MonoBehaviour
{
   // public TextMeshPro ValueText;
    public float Compressions;
    public TMP_Text CompText;
    public float time = 0;
    public float BPM=0;


    void Update()
    {
        CompText.text = Compressions.ToString();
    }
    private void OnTriggerExit(Collider other)
    {
       // ScoreCounter.scoreValue = ScoreCounter.scoreValue + 1;
       //
       //
        if (/*other.gameObject.tag == "Left Hand" &&*/ other.gameObject.tag == "Right Hand")

        {
            Compressions = Compressions + 1;

            Debug.Log(Compressions);
        }
    }
}
