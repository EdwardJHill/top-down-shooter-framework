using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class timer : MonoBehaviour
{
    public float timeRemaining = 90;
    public int numberScore = 0;
    public TMP_Text timeText;
    public TMP_Text Score;
    public GameObject SpeedUpPrefab;
    public GameObject BulletSizeUpPrefab;
    // Start is called before the first frame update
    
    // Update is called once per frame
    public GameOver GameOver;
    int maxPlatform = 0;
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
        DisplayScore(numberScore);
    }
    public void DoTheGameOver() {
        GameOver.Setup(numberScore,timeRemaining);
    }
    void DisplayTime(float theTime)
    {
        float minutes = Mathf.FloorToInt(theTime / 60);
        float seconds = Mathf.FloorToInt(theTime % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void DisplayScore(int scoore)
    {
        Score.text = scoore.ToString() + " points";
    }
    public void addToScore(int scoore)
    {
        numberScore += scoore;
        if((numberScore % 600)==0)
        {
            int powerUpToSpawn = Random.Range(1,3);
            if(powerUpToSpawn == 1)
            {
                GameObject SpeedUp = Instantiate(SpeedUpPrefab, new Vector3(Random.Range(-10.5f, 8.5f),Random.Range(-4.5f,2.5f),0), Quaternion.identity);
            }
            else if(powerUpToSpawn == 2)
            {
                GameObject BulletUp = Instantiate(BulletSizeUpPrefab, new Vector3(Random.Range(-10.5f, 8.5f),Random.Range(-4.5f,2.5f),0), Quaternion.identity);
            }
        }
    }
    

}
