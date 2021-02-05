using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    public static bool gameOver;
    public static int socialLife;
    public static int academicLife;
    public static int distance;

    public Text socialLifeText;
    public Text academicLifeText;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        distance = 0;
        socialLife = 0;
        academicLife = 1;
        Time.timeScale = 1;
        FindObjectOfType<AudioManager>().PlaySound("Theme");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver) {
            Time.timeScale = 0;
            SceneManager.LoadScene("Credits");
        }

        if (academicLife == 0) {
            gameOver = true;
        }

        socialLifeText.text = "Social Life: " + socialLife;
        academicLifeText.text = "Academic Life " + academicLife + "/10";
    }
}
