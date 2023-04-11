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

    public float goodCompressions = 0;

    public TMP_Text CompText;

    public GameObject RescueBreathCanvas;
   // public GameObject RescueBreath2;
   

    public GameObject BPMChecker;

    public GameObject CheckMarkBPM;



    public GameObject EvalText;
  

    public GameObject testImage;

    public GameObject QuestMarker;

    public GameObject RescueBreathMarker;

    float timer = 0;

    private Image imageComp;

    


    void Start()
    {
        imageComp = testImage.GetComponent<Image>();
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

            if (GetTime<=0.2f) //Red too quick
            
            {
                
                imageComp.color = new Color32(255, 0, 0, 255);
                EvalText.GetComponent<TextMeshProUGUI>().text = "Too quick";

                //Debug.Log("Very fast");
            }

            if(GetTime >= 0.3 && GetTime <= 0.4) // Yellow Decrease 
            {
              imageComp.color = new Color32(255,186,0,255);
              EvalText.GetComponent<TextMeshProUGUI>().text = "Decrease Speed";
              //Debug.Log("Decrease speed");

            }

            if (GetTime >= 0.5f && GetTime <= 0.6f) // Green Optimal
            {
                
               imageComp.color = new Color32(0, 255, 15, 255);
                EvalText.GetComponent<TextMeshProUGUI>().text = "Optimal";
                goodCompressions++;
                Debug.Log(goodCompressions);
               // Debug.Log("Optimal");
            }

            if(GetTime>=0.7 && GetTime<=0.8) // Yellow Increase
            {

              imageComp.color = new Color32(255,186,0,255);
              EvalText.GetComponent<TextMeshProUGUI>().text = "Increase Speed";
             // Debug.Log("Increase speed");

            }

            if (GetTime>=0.9) // Red Too slow
            {

                imageComp.color = new Color32(255, 0, 0, 255);
                EvalText.GetComponent<TextMeshProUGUI>().text = "Too slow";
               // Debug.Log("Too slow");
            }

            if (Compressions == 30)
            {
                Object.Destroy(BPMChecker, 1.0f);
                BPMChecker.GetComponent<BoxCollider>().enabled = false;

                QuestMarker.SetActive(false);
                CheckMarkBPM.SetActive(true);
                
               // Debug.Log("Condition working");

                
              

            }
                  
        }
    }

    void OnDestroy()
    {

        RescueBreathMarker.SetActive(true);
        RescueBreathCanvas.SetActive(true);
    }
}
