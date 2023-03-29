using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class BreathCheckScript : MonoBehaviour
{

    public GameObject TimerCanvas;


    private void OnTriggerEnter()
    {

        TimerCanvas.SetActive(true);
        
    }

    private void OnTriggerExit()
    {
        TimerCanvas.SetActive(false);

    }
}
