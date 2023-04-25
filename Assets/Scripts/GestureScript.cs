using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureScript : MonoBehaviour
{

    public GameObject GestureHands;

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Right Hand")
        {
            GestureHands.SetActive(false);
        }

    }
}
