using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimationInput : MonoBehaviour
{

    public InputActionProperty PinchAction;
    public InputActionProperty GripAction; 
    public Animator HandAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float TriggerValue = PinchAction.action.ReadValue<float>();
        HandAnimator.SetFloat("Trigger", TriggerValue);

        float GripValue = GripAction.action.ReadValue<float>();
        HandAnimator.SetFloat("Grip", GripValue);
    }
}
