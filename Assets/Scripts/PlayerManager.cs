using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    public static bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver) {
            Debug.Log("ASDASdasd");
            Time.timeScale = 0;
            SceneManager.LoadScene("Credits");
        }
    }
}
