using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenGame : MonoBehaviour
{
    public void LoadGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
