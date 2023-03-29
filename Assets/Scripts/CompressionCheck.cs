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

    public float GetTime;

    public TMP_Text CompText;

    public TMP_Text BeatText;


    float timer = 0;

   // public float BPM=0;


    private float compressRate;

    private float IntervalTime;


    void Update()
    {
        CompText.text = Compressions.ToString();

        BeatText.text = GetTime.ToString();

        timer += Time.deltaTime;

       // IntervalTime=
    }
    private void OnTriggerExit(Collider other)
    {
       // ScoreCounter.scoreValue = ScoreCounter.scoreValue + 1;
       //
       //
        if (/*other.gameObject.tag == "Left Hand" &&*/ other.gameObject.tag == "Right Hand")

        {
            Compressions = Compressions + 1;


             GetTime = timer;

             timer = 0;

            
            if(GetTime<0.6f)
            {
                Debug.Log("Very fast");
            }

            if(GetTime >= 0.6f && GetTime <= 1)
            {
                Debug.Log("Optimal");
            }

            if(GetTime>1)
            {
                Debug.Log("Too slow");
            }
                    
            
                
           // Debug.Log(Compressions);
        }
    }
}
