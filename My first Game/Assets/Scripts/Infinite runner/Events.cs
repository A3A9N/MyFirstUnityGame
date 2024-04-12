using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void Replaygame()
    {
        SceneManager.LoadScene("Player game");
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
