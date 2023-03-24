using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerTry : MonoBehaviour
{
    public TMP_Text CountdownText;


    public GameObject BreathCheckCanvas;
    

    float CurrentTime = 0f;
    float StartingTime = 10f;

    private void Start()
    {

        CurrentTime = StartingTime;

    }

    //void ond 
    //{
    //    CurrentTime = StartingTime;
    //}
    private void OnDisable()
    {
        CurrentTime = StartingTime;
    }

    private void Update()
    {
        CurrentTime -= 1 * Time.deltaTime;
        CountdownText.text = CurrentTime.ToString("0");

        if(CurrentTime<=0)
        {
            CurrentTime = 0;
        }


        if (!BreathCheckCanvas.activeInHierarchy)
        {


            //CurrentTime = StartingTime;
            Debug.Log("Gameobject is inactive");
        }

       
    }

    void ResetTimer()
    {
        if(!BreathCheckCanvas.activeInHierarchy)
        {

            CurrentTime = StartingTime;
            Debug.Log("Gameobject is inactive");
        }
    }
}
