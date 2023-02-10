using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    //ends program
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    //loads scene
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
