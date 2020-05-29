using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePlay : MonoBehaviour
{
    public static bool GamePause = false;

    public GameObject PauseUI;

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenuScreenLoad() {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

     public void Resume()
      {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false; 
     }

        public void pause()
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0f;
            GamePause = true;
        }
}
