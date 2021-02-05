using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits : MonoBehaviour
{
    void Start() {
        FindObjectOfType<AudioManager>().PlaySound("GameOver");
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
