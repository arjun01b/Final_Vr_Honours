using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{

    public float amp;
    public float freq;
    Vector3 initPos;


    private void Start()
    {
        initPos = transform.position;
    }




    void Update()
    {

        // transform.Rotate(new Vector3(0, amp * Time.deltaTime, 0));
        transform.position = new Vector3(initPos.y, Mathf.Sin(Time.time * freq) * amp, 0);
    }
}
