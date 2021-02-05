using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Credits : MonoBehaviour
{

    public Text totalScore;
    private int newScore;

    void Start() {
        FindObjectOfType<AudioManager>().PlaySound("GameOver");

    }

    void Update()
    {
        newScore = PlayerManager.socialLife + PlayerManager.academicLife + PlayerManager.distance;
        totalScore.text = newScore.ToString("0");
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
