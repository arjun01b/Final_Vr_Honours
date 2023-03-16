using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompressionCheck : MonoBehaviour
{

    public int score = 0;

    private void OnTriggerExit()
    {

        score = score+1;

        Debug.Log(score);
        
    }
}
