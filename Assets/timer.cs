using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class timer : MonoBehaviour
{
    public float timeRemaining = 90;
    public TMP_Text timeText;
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
        DisplayTime(timeRemaining);
    }
    void DisplayTime(float theTime)
    {
        float minutes = Mathf.FloorToInt(theTime / 60);
        float seconds = Mathf.FloorToInt(theTime % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    

}
