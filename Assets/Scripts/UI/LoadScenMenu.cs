using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenMenu : MonoBehaviour
{
    public void LoadMenu()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(0);
    }
}
