using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class BreathCheckScript : MonoBehaviour
{

    public GameObject TimerCanvas;

    //public TMP_Text CountdownText;

    //float CurrentTime = 0f;
    //float StartingTime = 10f;

    //private void Start()
    //{

    //    CurrentTime = StartingTime;

    //}

    //private void Update()
    //{ 


    //    CurrentTime -= 1 * Time.deltaTime;
    //    CountdownText.text = CurrentTime.ToString("0");


    //    if (CurrentTime <= 0)
    //    {
    //        CurrentTime = 0;
    //    }
    //  //  Debug.Log(CurrentTime);
    //}

    private void OnTriggerEnter()
    {

        TimerCanvas.SetActive(true);
        
    }

    private void OnTriggerExit()
    {
        TimerCanvas.SetActive(false);

    }
}
