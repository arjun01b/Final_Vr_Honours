using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class BreathCheckScript : MonoBehaviour
{

    public GameObject TimerCanvas;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            TimerCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "MainCamera")
        {
            TimerCanvas.SetActive(false);

        }

    }
}
