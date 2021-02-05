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

    public Text scoreLabel;
    public Text score;

    public static bool isNight;

    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        isNight = false;
        distance = 0;
        socialLife = 0;
        academicLife = 1;
        Time.timeScale = 1;
        cam.clearFlags = CameraClearFlags.SolidColor;
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

        //night time day time will change every 100 distance
        int remainder = distance / 100;
        if (remainder % 2 == 0)
        {
            isNight = false;
        }
        else {
            isNight = true;
        }


        if (isNight)
        {
            cam.backgroundColor = Color.black;
            socialLifeText.color = Color.white;
            academicLifeText.color = Color.white;
            scoreLabel.color = Color.white;
            score.color = Color.white;
            RenderSettings.fogColor = Color.black;
        }
        else
        {
            cam.backgroundColor = Color.white;
            socialLifeText.color = Color.grey;
            academicLifeText.color = Color.grey;
            scoreLabel.color = Color.grey;
            score.color = Color.grey;
            RenderSettings.fogColor = Color.white;
        }

        socialLifeText.text = "Social Life: " + socialLife;
        academicLifeText.text = "Academic Life " + academicLife + "/10";
    }
}
