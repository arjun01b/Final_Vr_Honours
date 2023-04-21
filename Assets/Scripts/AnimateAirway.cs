using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateAirway : MonoBehaviour
{

    [SerializeField] private Animator MyAnimationController;
    public GameObject CheckMark;
    public GameObject BreathCheckBox;
    public GameObject PointerArrowBreathCheck;
    public GameObject IndicatorHand;
    public GameObject HumanHead; 


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Left Hand")
        {
            MyAnimationController.SetBool("playHeadTilt", true);
            CheckMark.SetActive(true);
            Debug.Log("Collision true");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Left Hand")
        {
            IndicatorHand.SetActive(false);
            PointerArrowBreathCheck.SetActive(true);
            BreathCheckBox.SetActive(true);
            HumanHead.SetActive(true);
            Debug.Log("Collision false");
        }
    }
}
