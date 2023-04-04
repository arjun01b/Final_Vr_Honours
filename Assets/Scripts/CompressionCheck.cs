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

   

    public GameObject BPMChecker;

    public GameObject CheckMarkBPM;



    public GameObject EvalText;
  

    public GameObject testImage;

    float timer = 0;

  


    void Start()
    {
        
    }

    void Update()
    {
        CompText.text = Compressions.ToString();

       // BeatText.text = GetTime.ToString();

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

            testImage.SetActive(true);

            if (GetTime<0.6f)
            
            {
                
                testImage.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
                EvalText.GetComponent<TextMeshProUGUI>().text = "Too quick";

                Debug.Log("Very fast");
            }

            //if(GetTime)
            //{

            //}

            if(GetTime >= 0.6f && GetTime <= 1)
            {
                
                testImage.GetComponent<Image>().color = new Color32(0, 255, 15, 255);
                EvalText.GetComponent<TextMeshProUGUI>().text = "Optimal";
                Debug.Log("Optimal");
            }

            //if(GetTime)
            //{

            //}

            if(GetTime>1)
            {

  

                testImage.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
                EvalText.GetComponent<TextMeshProUGUI>().text = "Too slow";
                Debug.Log("Too slow");
            }

            if (Compressions == 30)
            {
                Object.Destroy(BPMChecker, 1.0f);
                BPMChecker.GetComponent<BoxCollider>().enabled = false;
                CheckMarkBPM.SetActive(true);
                Debug.Log("Condition working");

            }

            // Debug.Log(Compressions);
        }

        


    }
}
