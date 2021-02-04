using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void ReplayGame() {
        Debug.Log("REPLAY");
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
