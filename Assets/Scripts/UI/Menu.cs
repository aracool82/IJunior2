using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadMenu()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
