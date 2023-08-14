using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class YouWin : MonoBehaviour
{
    // Start is called before the first frame update
    public Text pointsText;
    // Start is called before the first frame update
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS \n";
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
