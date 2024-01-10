using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;
    [SerializeField] GameObject pauseMenu;
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        IsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1; 
        IsPaused = false;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1; 
        IsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1; 
        IsPaused = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
