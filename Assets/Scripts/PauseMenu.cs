using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;
    public GameObject Menu;

    private void Start()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    /*public GameObject menu;
    public bool isPaused = false;

    private void Start()
    {
        if (GameManager.Instance == null)
        {
            GameManager.Instance.UnPauseMusic();
        }

        menu.SetActive(false);
        Time.timeScale = 1f;
    }*/
    private void Update()
    {
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
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void Resume()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    void Pause()
    {
        Menu.SetActive(true);
        Time.timeScale = 0.0f;
        IsPaused = true;
    }
}
    /*public void TogglePauseGame()
    {
        isPaused = !isPaused;

        //will open and close menu
        menu.SetActive(isPaused);

        controlling music depending on if the game is paused or not
        if (isPaused = true)
        if (isPaused)
        {
            Time.timeScale = 0f;
            //GameManager.Instance.audio.pitch = 0f;
            GameManager.Instance.PauseMusic();

        }
        else
        {
            Time.timeScale = 1f;
            //GameManager.Instance.audio.pitch = 1f;
            GameManager.Instance.UnPauseMusic();

        }
    }*/
