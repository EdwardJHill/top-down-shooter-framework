using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public Text pointsAndTimeText;
    // Start is called before the first frame update
    public void Setup(int score,float time)
    {
        gameObject.SetActive(true);
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        pointsAndTimeText.text = score.ToString() + " POINTS \n" + "TIME REMAINING: "+ minutes.ToString() + ":" + seconds.ToString();
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("default");
        Time.timeScale= 1f;

    }
    public void ExitButton()
    {
        Application.Quit();
        Time.timeScale= 1f;
    }
}
