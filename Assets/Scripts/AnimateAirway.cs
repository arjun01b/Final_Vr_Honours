using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateAirway : MonoBehaviour
{

    [SerializeField] private Animator MyAnimationController;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Left Hand"))
        {
            MyAnimationController.SetBool("playHeadTilt", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Left Hand"))
        {
            MyAnimationController.SetBool("playHeadTilt", false);
        }
    }
}
