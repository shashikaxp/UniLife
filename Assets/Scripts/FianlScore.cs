using UnityEngine.UI;
using UnityEngine;

public class FianlScore : MonoBehaviour
{
    public Text totalScore;
    private int newScore;
    // Start is called before the first frame update
    void Start()
    {
        newScore = PlayerManager.socialLife + PlayerManager.academicLife + PlayerManager.distance;
        totalScore.text = newScore.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
