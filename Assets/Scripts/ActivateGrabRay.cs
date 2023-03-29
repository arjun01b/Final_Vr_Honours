using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateGrabRay : MonoBehaviour
{

    public GameObject LeftGrabRay;

    public XRDirectInteractor leftDirectGrab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        LeftGrabRay.SetActive(leftDirectGrab.interactablesSelected.Count == 0);
       
        
    }
}
