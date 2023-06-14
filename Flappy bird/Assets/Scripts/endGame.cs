using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    public GameObject PauseMenu;
    // Start is called before the first frame update
    public void Pause()
    {
        // Application.Quit();
        // UnityEditor.EditorApplication.isPlaying = false;
        // UnityEditor.EditorApplication.isPaused = true;
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
        // UnityEditor.EditorApplication.isPlaying = false;
        // UnityEditor.EditorApplication.isPaused = true;
    }

    public void restart () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
