using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerTry : MonoBehaviour
{
    public TMP_Text CountdownText;

    public GameObject BreathCheckGameObject;

    public GameObject BreathCheckCanvas;

    public GameObject BreathTickMark;

    public GameObject CPRGameObject;

    public GameObject QuestArrowBreath;

    public GameObject QuestArrowCPR;

    public GameObject cubeBeat;

    float CurrentTime = 0f;
    float StartingTime = 10f;

    private void Start()
    {

        CurrentTime = StartingTime;

    }

 
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
            Object.Destroy(BreathCheckGameObject, 0);


            cubeBeat.SetActive(true);

            QuestArrowCPR.SetActive(true);

            BreathTickMark.SetActive(true);

            QuestArrowBreath.SetActive(false);

            CPRGameObject.SetActive(true);



             

        }


       

       
    }

    
}
