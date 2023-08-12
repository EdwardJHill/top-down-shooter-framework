using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float timeRemaining = 90;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if ( timeRemaining > 0)
        {
        timeRemaining -= Time.deltaTime;
        }
        else
        {

        }
    }
    void DisplayTime(float theTime)
    {
        float minutes = Mathf.FloorToInt(theTime / 60);
    }

}
