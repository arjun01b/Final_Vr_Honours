using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource BPMClip;

    public GameObject cube;

    //public CompressionCheck CompVar;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Right Hand")
        {
            BPMClip.Play();
            cube.GetComponent<BoxCollider>().enabled = false;
        }
       
        
    }
}
