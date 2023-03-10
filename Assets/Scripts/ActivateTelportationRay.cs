using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTelportationRay : MonoBehaviour
{
    public GameObject RightHandTeleportation;


    public InputActionProperty RightActivate;



    // Update is called once per frame
    void Update()
    {
        RightHandTeleportation.SetActive(RightActivate.action.ReadValue<float>() > 0.1f);
        
    }
}
