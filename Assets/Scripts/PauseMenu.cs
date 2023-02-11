using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
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
    }
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }

    public void TogglePauseGame()
    {
        isPaused = !isPaused;

        //will open and close menu
        menu.SetActive(isPaused);

        /controlling music depending on if the game is paused or not
        //if (isPaused = true)
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

        }*/
    }
