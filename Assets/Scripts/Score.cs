using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerManager.gameOver) {
            PlayerManager.distance = (int)player.position.z;
            score.text = PlayerManager.distance.ToString("0");
        }
    }
}
